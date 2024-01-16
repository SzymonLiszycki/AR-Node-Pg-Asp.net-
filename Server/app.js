const express = require('express');
const bodyParser = require('body-parser');
const { Pool } = require('pg');
const fs = require('fs');

const app = express();

app.use(bodyParser.json());

const rawdata = fs.readFileSync('config.json');
const config = JSON.parse(rawdata);
const dbConfig = config.dbConfig;
const serverConfig = config.serverConfig;

const pool = new Pool({
    user: dbConfig.user,
    host: dbConfig.host,
    database: dbConfig.database,
    password: dbConfig.password,
    port: dbConfig.port,
});

pool.query(`
   CREATE TABLE IF NOT EXISTS tasks (
     id SERIAL PRIMARY KEY,
     title VARCHAR(100) NOT NULL,
     completed BOOLEAN DEFAULT false
   )
 `);

const ip = serverConfig.ip || 'localhost';  
const port = serverConfig.port || 3000;      

app.get('/tasks', async (req, res) => {
    try {
        const { rows } = await pool.query('SELECT * FROM tasks');
        res.json({ tasks: rows });
    } catch (error) {
        console.error(error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
});

app.post('/tasks', async (req, res) => {
    const { title } = req.body;

    try {
        const { rows } = await pool.query('INSERT INTO tasks (title) VALUES ($1) RETURNING *', [title]);
        res.json({ message: 'Task created successfully', task: rows[0] });
    } catch (error) {
        console.error(error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
});

app.get('/tasks/:id', async (req, res) => {
    const taskId = req.params.id;

    try {
        const { rows } = await pool.query('SELECT * FROM tasks WHERE id = $1', [taskId]);

        if (rows.length === 0) {
            res.status(404).json({ error: 'Task not found' });
        } else {
            res.json({ task: rows[0] });
        }
    } catch (error) {
        console.error(error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
});

app.put('/tasks/:id', async (req, res) => {
    const taskId = req.params.id;
    const { title, completed } = req.body;

    try {
        const { rows } = await pool.query(
            'UPDATE tasks SET title = $1, completed = $2 WHERE id = $3 RETURNING *',
            [title, completed, taskId]
        );

        if (rows.length === 0) {
            res.status(404).json({ error: 'Task not found' });
        } else {
            res.json({ message: 'Task updated successfully', task: rows[0] });
        }
    } catch (error) {
        console.error(error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
});

app.delete('/tasks/:id', async (req, res) => {
    const taskId = req.params.id;

    try {
        const { rows } = await pool.query('DELETE FROM tasks WHERE id = $1 RETURNING *', [taskId]);

        if (rows.length === 0) {
            res.status(404).json({ error: 'Task not found' });
        } else {
            res.json({ message: 'Task deleted successfully', task: rows[0] });
        }
    } catch (error) {
        console.error(error);
        res.status(500).json({ error: 'Internal Server Error' });
    }
});

app.listen(port, ip, () => {
    console.log(`Server is running on http://${ip}:${port}`);
});

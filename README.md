ToDoList - ASP.NET MVC (Client) and Express + PostgreSQL (Server)

    Introduction
    ToDoList is a simple task list application created using the ASP.NET MVC framework. This project includes both the client, written in ASP.NET MVC, and the server using Express.js in conjunction with a PostgreSQL database. Below, you will find documentation for both the client and the server.
    ASP.NET MVC Client
    2.1. Client Project Structure
    The structure of the ASP.NET MVC client project looks as follows:

    Controllers: Controllers handling HTTP requests and managing business logic.
    Models: Models representing the data structures of the application.
    Views: Views responsible for presenting data to the user.
    wwwroot: Contains static resources such as CSS stylesheets, JavaScript scripts, etc.
    2.2. Client Features
    Homepage: Displays a list of tasks and allows for adding, viewing, updating, and deleting tasks.
    Forms: Handles forms for adding and updating tasks.
    2.3. Running the Client

    Running locally:
        Clone the repository: git clone https://github.com/SzymonLiszycki/Asp.net-express-js-Pg-.git
        Open the project in Visual Studio.
        Update the appsettings.json file according to the instructions in the "Installation" section in the README file.
        Run the application.

    Running on a server:
        Deploy the application to an ASP.NET server or cloud hosting such as Azure, AWS, or another provider.

    Express + PostgreSQL Server
    3.1. Server Project Structure
    The structure of the Express + PostgreSQL server project looks as follows:

    routes: Routes defining API endpoints.
    models: Data models representing the structures stored in the PostgreSQL database.
    config: Configuration, including the database connection.
    controllers: Controllers handling API requests.
    3.2. Server Features
    CRUD API: Provides CRUD operations to manage tasks in the database.
    PostgreSQL Connection: Utilizes a connection to the PostgreSQL database for storing and retrieving data.
    3.3. Running the Server

    Running locally:
        Install dependencies: npm install
        Run the server: node app.js

    Running on a server:
        Deploy the application to a Node.js server or cloud hosting such as Heroku, AWS, or another provider.

   

![Zrzut ekranu 2024-01-06 094522](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9b055e51-036d-4560-bc28-c31d2f2a148d)
![Zrzut ekranu 2024-01-06 094159](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/c69b1d58-0fcf-4e39-882a-737f8c28b76e)
![Zrzut ekranu 2024-01-06 094728](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/bd2fa2c4-9fe9-424b-8209-14df95f6bbeb)
![Zrzut ekranu 2024-01-06 094704](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/28131271-35bd-44dd-8477-b9a9a2aa6b6b)
![Zrzut ekranu 2024-01-06 094617](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/43446f70-8183-4424-aba7-4d0cd1199e1e)
![Zrzut ekranu 2024-01-06 094555](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9bb02871-e12a-4de2-bda7-f6675b733a89)

ToDoList - ASP.NET MVC (Klient) i Express + PostgreSQL (Serwer)

    Wprowadzenie
    ToDoList to prosta aplikacja listy zadań stworzona przy użyciu platformy ASP.NET MVC. Projekt ten obejmuje zarówno klienta, napisanego w technologii ASP.NET MVC, jak i serwer wykorzystujący Express.js w połączeniu z bazą danych PostgreSQL. Poniżej znajdziesz dokumentację dla klienta i serwera.
    Klient ASP.NET MVC
    2.1. Struktura Projektu Klienta
    Struktura projektu klienta ASP.NET MVC wygląda następująco:

    Controllers: Kontrolery obsługujące żądania HTTP i zarządzające logiką biznesową.
    Models: Modele reprezentujące struktury danych aplikacji.
    Views: Widoki odpowiadające za prezentację danych użytkownikowi.
    wwwroot: Zawiera zasoby statyczne, takie jak arkusze stylów CSS, skrypty JavaScript, itp.
    2.2. Funkcje Klienta
    Strona główna: Wyświetla listę zadań oraz umożliwia dodawanie, przeglądanie, aktualizację i usuwanie zadań.
    Formularze: Obsługuje formularze do dodawania i aktualizacji zadań.
    2.3. Uruchamianie

    Uruchamianie lokalnie:
        Sklonuj repozytorium: git clone https://github.com/SzymonLiszycki/Asp.net-express-js-Pg-.git
        Otwórz projekt w Visual Studio.
        Zaktualizuj plik appsettings.json zgodnie z instrukcjami w sekcji "Instalacja" w pliku README.
        Uruchom aplikację.
    Uruchamianie na serwerze:
        Wdrożenie aplikacji na serwerze ASP.NET lub hostingu chmurowym, takim jak Azure, AWS lub inny.
    Serwer Express + PostgreSQL
    3.1. Struktura Projektu Serwera
    Struktura projektu serwera Express + PostgreSQL wygląda następująco:

    routes: Trasy definiujące punkty końcowe API.
    models: Modele danych reprezentujące struktury przechowywane w bazie PostgreSQL.
    config: Konfiguracja, w tym połączenie z bazą danych.
    controllers: Kontrolery obsługujące żądania API.
    3.2. Funkcje Serwera
    API CRUD: Udostępnia operacje CRUD do zarządzania zadaniami w bazie danych.
    Połączenie z PostgreSQL: Wykorzystuje połączenie z bazą danych PostgreSQL do przechowywania 
![Zrzut ekranu 2024-01-06 094522](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9b055e51-036d-4560-bc28-c31d2f2a148d)
![Zrzut ekranu 2024-01-06 094159](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/c69b1d58-0fcf-4e39-882a-737f8c28b76e)
![Zrzut ekranu 2024-01-06 094728](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/bd2fa2c4-9fe9-424b-8209-14df95f6bbeb)
![Zrzut ekranu 2024-01-06 094704](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/28131271-35bd-44dd-8477-b9a9a2aa6b6b)
![Zrzut ekranu 2024-01-06 094617](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/43446f70-8183-4424-aba7-4d0cd1199e1e)
![Zrzut ekranu 2024-01-06 094555](https://github.com/SzymonLiszycki/SimpleToDoList/assets/103385581/9bb02871-e12a-4de2-bda7-f6675b733a89)

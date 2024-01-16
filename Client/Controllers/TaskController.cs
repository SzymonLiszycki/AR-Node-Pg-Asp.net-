using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Client.Models;

namespace Client.Controllers
{
    public class TaskController : Controller
    {
        private readonly HttpClient _httpClient;

        public TaskController()
        {
            _httpClient = new HttpClient { BaseAddress = new System.Uri("http://localhost:3000/") };
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                var response = await _httpClient.GetAsync("tasks");

                if (response.IsSuccessStatusCode)
                {                 
                    var content = await response.Content.ReadAsStringAsync();
                    var taskResponse = JsonConvert.DeserializeObject<TaskResponse>(content);

                    return View(taskResponse.Tasks);
                }
                else
                {
                  
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                
                return View("Error");
            }
        }

        // GET: TaskController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"tasks/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                TaskModel task = JsonConvert.DeserializeObject<TaskModel>(content);

                return View(task);
            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TaskModel task)
        {
            try
            {
                var json = JsonConvert.SerializeObject(task);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("tasks", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"tasks/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var task = JsonConvert.DeserializeObject<TaskModel>(content);

                return View(task);
            }

            return View();
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, TaskModel task)
        {
            try
            {
                var json = JsonConvert.SerializeObject(task);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"tasks/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View(task);
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"tasks/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                TaskModel task = JsonConvert.DeserializeObject<TaskModel>(content);

                return View(task);
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"tasks/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}

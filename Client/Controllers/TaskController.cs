using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Client.Controllers
{
    public class TaskController : Controller
    {
        private readonly HttpClient _httpClient;

        public TaskController()
        {
            _httpClient = new HttpClient { BaseAddress = new System.Uri("http://localhost:3000/") };
        }

        // GET: TaskController
        public async Task<ActionResult> Index()
        {
            var response = await _httpClient.GetAsync("tasks");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var tasks = JsonConvert.DeserializeObject<IEnumerable<Task>>(content);

                return View(tasks);
            }

            return View();
        }

        // GET: TaskController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"tasks/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var task = JsonConvert.DeserializeObject<Task>(content);

                return View(task);
            }

            return View();
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Task task)
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
                var task = JsonConvert.DeserializeObject<Task>(content);

                return View(task);
            }

            return View();
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Task task)
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

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"tasks/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var task = JsonConvert.DeserializeObject<Task>(content);

                return View(task);
            }

            return View();
        }

        // POST: TaskController/Delete/5
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

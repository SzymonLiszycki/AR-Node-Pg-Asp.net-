using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}

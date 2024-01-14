using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}

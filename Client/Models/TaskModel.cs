using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [DisplayName("Tytuł")]
        public string title { get; set; }
        [DisplayName("Ukończono")]
        public bool completed { get; set; }
    }
}

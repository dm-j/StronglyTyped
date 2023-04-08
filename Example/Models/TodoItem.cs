using System.ComponentModel.DataAnnotations.Schema;
using static Example.TodoItems;

namespace Example.Models
{
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Id Id { get; set; }

        public Name? Name { get; set; }

        public IsComplete IsComplete { get; set; }
    }
}

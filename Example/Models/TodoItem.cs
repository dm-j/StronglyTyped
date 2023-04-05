﻿using static Example.TodoItems;
using Swashbuckle.AspNetCore.Annotations;

namespace Example.Models
{
    public class TodoItem
    {
        public Id Id { get; set; }
        public Name? Name { get; set; }
        public IsComplete IsComplete { get; set; }
    }
}

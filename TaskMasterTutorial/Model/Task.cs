using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMasterTutorial.Model
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }

        // Naming convention over configuration.
        // Saying this is foreign key for Status class.
        public int StatusId { get; set; } 

        public Status Status { get; set; }
    }
}

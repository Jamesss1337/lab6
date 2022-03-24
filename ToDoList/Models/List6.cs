using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class List6
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List6(string title, string description)
        {
            this.Title = title;
            this.Description = description;

        }
        
    }
}

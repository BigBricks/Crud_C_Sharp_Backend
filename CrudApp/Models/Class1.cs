using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudApp.Models
{
    public class Todo
    {
        public long id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
    }
}
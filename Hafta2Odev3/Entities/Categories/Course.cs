using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Categories
{
    public class Course : Category
    {
        public string courseName { get; set; }

        public int courseId { get; set; }

        public string instructor { get; set; }
    }
}

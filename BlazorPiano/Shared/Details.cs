using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPiano.Shared
{
    public class Details
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LessonDetails { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}

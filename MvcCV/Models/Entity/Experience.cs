using System;
using System.Collections.Generic;

#nullable disable

namespace MvcCV.Models.Entity
{
    public partial class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTtitle { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}

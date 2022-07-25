using System;
using System.Collections.Generic;

#nullable disable

namespace MvcCV.EntiyLayer.Concrete
{
    public partial class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle1 { get; set; }
        public string SubTitle2 { get; set; }
        public string GradeAverage { get; set; }
    }
}

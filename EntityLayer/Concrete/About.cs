using System;
using System.Collections.Generic;

#nullable disable

namespace MvcCV.EntiyLayer.Concrete
{
    public partial class About
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
    }
}

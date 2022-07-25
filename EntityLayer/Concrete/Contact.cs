using System;
using System.Collections.Generic;

#nullable disable

namespace MvcCV.EntiyLayer.Concrete
    public partial class Contact
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
    }
}

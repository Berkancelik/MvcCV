﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MvcCV.Models.Entity
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

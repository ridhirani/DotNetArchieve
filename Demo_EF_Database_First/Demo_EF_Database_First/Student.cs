﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo_EF_Database_First
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Contact { get; set; }
    }
}

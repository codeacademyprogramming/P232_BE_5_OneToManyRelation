﻿using System.Collections.Generic;

namespace UniversityApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string No { get; set; }

        public List<Student> Students { get; set; }
        
    }
}

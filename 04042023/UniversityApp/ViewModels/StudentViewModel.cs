using System.Collections.Generic;
using UniversityApp.Models;

namespace UniversityApp.ViewModels
{
    public class StudentViewModel
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
    }
}

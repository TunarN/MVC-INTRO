using P326FirstWebApp.Models;
using System.Collections.Generic;

namespace P326FirstWebApp.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }

        public List<Group> Groups { get; set; }
    }
}

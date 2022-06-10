using HomeTask_BizLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask_BizLand.ViewModel
{
    public class HomeViewModel
    {
        public List<Category> categories { get; set; }
        public List<Project> projects { get; set; }
    }
}

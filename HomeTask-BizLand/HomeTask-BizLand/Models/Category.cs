using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask_BizLand.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}

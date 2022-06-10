using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask_BizLand.Models
{
    public class Project:BaseEntity
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

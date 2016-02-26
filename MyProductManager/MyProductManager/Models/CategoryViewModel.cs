using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProductManager.Models
{
  public  class CategoryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Category Name is requered")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }
    }
}

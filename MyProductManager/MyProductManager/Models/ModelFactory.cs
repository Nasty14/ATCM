using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProductManager.Models
{
    class ModelFactory
    {
        public static Category Create(CategoryViewModel model)
        {
            return new Category
            {
                ID = model.Id,
                Name = model.Name,
            };
        }
    }
}

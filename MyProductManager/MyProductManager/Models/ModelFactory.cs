﻿using System;
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

        public static ProductResponceModel Create(Product model)
        {
            return new ProductResponceModel
            {
                Id = model.ID,
                Name = model.Name,
                Categories = model.Category.Name
            };
        }
    }

    public class ProductResponceModel //Create(Product model)
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Categories { get; set; }
    }
}

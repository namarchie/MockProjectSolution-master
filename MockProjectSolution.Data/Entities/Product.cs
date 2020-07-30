﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MockProjectSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string Account { set; get; }
        public string Password { set; get; }
        public decimal Price { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime DateCreated { set; get; }
        public string Image { set; get; }
        public int CategoryId { set; get; }
        public Category Category { set; get; }
    }
}

﻿using System.Collections.Generic;

namespace BaseAPI.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
    }
}
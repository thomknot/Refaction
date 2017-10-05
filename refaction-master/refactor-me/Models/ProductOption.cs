﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace refactor_me.Models
{
    public class ProductOption
    {
        public Guid ProductOptionId { get; set; }

        public Guid ProductId { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [JsonIgnore]
        [Required]
        public virtual Product product { get; set; } = new Product();
    }


}
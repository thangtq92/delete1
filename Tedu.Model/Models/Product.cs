﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu.Model.Models
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}

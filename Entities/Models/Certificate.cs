﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Institution { get; set; }
        public DateTime Date { get; set; }
    }
}

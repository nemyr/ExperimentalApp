﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exp1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Specify whether you`ll attend")]
        public bool? WillAttend { get; set; }
    }
}

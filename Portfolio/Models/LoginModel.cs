﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }

    }
}

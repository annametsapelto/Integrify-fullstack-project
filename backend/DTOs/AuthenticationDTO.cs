namespace DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class AuthenticationDTO
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
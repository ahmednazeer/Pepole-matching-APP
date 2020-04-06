﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.Models;

namespace Dating.Dtos
{
    public class UserDetailDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string LookingFor { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
        public int Age { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoDetailDto> Photos { get; set; }
    }
}

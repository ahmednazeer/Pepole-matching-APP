﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string PublicId { get; set; }
        public bool IsMain { get; set; }
        //public DateTime AddedDate { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}

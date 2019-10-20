﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UNFHackathonManagementSystem.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public int StartDate { get; set; }

        public int EndDate { get; set; }

        public string Description { get; set; }

    }
}

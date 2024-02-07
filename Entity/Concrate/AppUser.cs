﻿using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class AppUser :IdentityUser<int>
    {


		public string? ImageUrl { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string? Gender { get; set; }
        public List<Reservation> Reservations { get; set; }


    }

}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cw12.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Prescription = new HashSet<Prescription>();
        }

        
        public int IdDoctor { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}

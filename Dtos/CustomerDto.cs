using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieLab.Models;

namespace MovieLab.Dtos
{
    public class CustomerDto
    {
         public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}
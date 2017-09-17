﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
  public class CustomerDto
  {
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    public bool IsSubscribedToNewsLetter { get; set; }

    public byte MemberShipTypeId { get; set; }

    public MembershipTypeDto MembershipType { get; set; }

    //[Min18YearsIfAMember]
    public DateTime? BirthDate { get; set; }
  }
}
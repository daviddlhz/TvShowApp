﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public enum Genre
    {
        Drama,
        Comedy,
        Romance,
        [Display(Name = "Romantic Comedy")]
        RomCom,
        Crime,
        Mystery
    }
}

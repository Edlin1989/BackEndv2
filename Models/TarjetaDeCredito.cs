﻿using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndv2.Models
{
    public class TarjetaDeCredito
    {
       [Key] 
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Titular { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroTarjeta { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string FechaExpiracion { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}

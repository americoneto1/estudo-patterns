using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculadoraDeImpostos.Web.Models
{
    public class CalculadoraViewModel
    {
        [Required]
        [Display(Name = "Salário")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString="{0:C2}")]
        public double Salario { get; set; }

        [Display(Name = "Imposto")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Imposto { get; set; }
    }
}
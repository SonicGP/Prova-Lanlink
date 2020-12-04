using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendCont.Models
{
    public class Tipo
    {
        [Key]
        public int TipoId { get; set; }

        [Display(Name = "Tipo de Moradia")]
        public string Descripition { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
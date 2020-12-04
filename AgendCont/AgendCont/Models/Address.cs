using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendCont.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "O Campo {0} é requedido!")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]        
        public string Number { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Display(Name = "Tipo")]
        public int TipoId { get; set; }        
        //public string Type { get; set; }

        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "Pessoa")]
        public int PersonId { get; set; }
       
        public virtual Person Person { get; set; }

        public virtual Tipo Tipo { get; set; }
    }
}
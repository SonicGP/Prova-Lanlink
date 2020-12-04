using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendCont.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo {0} é requedido!")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Address> Addresses { get; set; }

        [JsonIgnore]
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
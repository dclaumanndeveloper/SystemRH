using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemRH.Models
{
    public class Recruiter
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Razão Social é obrigatório",AllowEmptyStrings =false)]
        [Display(Name = "Razão Social")]
        public String CompanyName { get; set; }
        [Display(Name = "Nome Fantasia")]
        public String FantasyName { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório",AllowEmptyStrings = false)]

        public String CNPJ { get; set; }
        [Required(ErrorMessage = "CEP é obrigatório",AllowEmptyStrings = false)]
        public String Cep { get; set; }
        [Display(Name = "Logradouro")]
        public String Adress { get; set; }
        [Display(Name = "Complemento")]
        public String Complement { get; set; }
        [Display(Name = "Bairro")]
        public String Neighborhood { get; set; }
        [Display(Name = "Cidade")]
        public String City { get; set; }
        [Display(Name = "Estado")]
        public String State { get; set; }
        public virtual Login Login { get; set; }
        [Display(Name = "Telefone")]
        public String Telephone { get; set; }
        [Display(Name = "Celular")]
        public String Cell { get; set; }
        public String Fax { get; set; }
        [Display(Name = "Situação")]
        public String Active { get; set; }
    }
}

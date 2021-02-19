using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemRH.Models
{
    public class Candidate
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo nome é obrigatório", AllowEmptyStrings = false)]
        public String Name { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório", AllowEmptyStrings = false)]
        public String Cpf { get; set; }
        [Display(Name = "RG")]
        [Required(ErrorMessage = "O campo RG é obrigatório", AllowEmptyStrings = false)]
        public String Rg { get; set; }
        [Display(Name = "Telefone")]
        public String Telphone { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O campo celular é obrigatório", AllowEmptyStrings = false)]
        public String Cell { get; set; }
        public virtual Login Login { get; set; }
        [Display(Name = "Situação")]
        public char Active { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemRH.Models
{
    public class Login
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Usuário Obrigatório",AllowEmptyStrings = false)]
        [Display(Name = "Usuário")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Senha Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Senha")]
        public String Password { get; set; }
        [Required(ErrorMessage = "E-mail Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "E-mail")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Tipo de Login Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Tipo de Login")]
        public Enumerators.TypeLogin TypeLogin { get; set; }
        [Display(Name = "Situação")]
        public char Active { get; set; }

    }
}

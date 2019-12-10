using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_mvc3.Models
{
    public class equipamentos
    {
        [Key]

        [Display(Name = "ID do equipamento")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public int equipamentosId { get; set; }

        [Display(Name = "Tipo do equipamento")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string tipo { get; set; }

        [Display(Name = "Nome da empresa")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string nome { get; set; }
 
        [Display(Name = "Endereco da empresa")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string logradouro { get; set; }

        [Display(Name = "Nome dos socios")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string qsa { get; set; } 

        [Display(Name = "CNPJ da empresa")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public int cnpj { get; set; }

        [Display(Name = "Nome do equipamento")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string equipamento { get; set; } 
    }
}
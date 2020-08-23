using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Models
{
    public class Abastecimento
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(10, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]

        [Display(Name = "Quilometragem")]
        public int Km { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(10, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]
        [Display(Name = "Litros")]
        public Decimal Litros { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [Display(Name = "Valor")]
        [StringLength(10, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]

        public Decimal Valor  { get; set; }
         
        [Display(Name = "Data Cadastro")]
        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DataAbastecimento { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]

        [Display(Name = "Posto")]
        public string Posto { get; set; }
         
        public string IdUser { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]

        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
         
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}

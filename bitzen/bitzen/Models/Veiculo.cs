using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Models
{
    public class Veiculo
    {

        [Key]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 2)]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 2)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(4, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 4)]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(8, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 4)]
        
        [Display(Name = "Placa")]
        public string Placa { get; set; }


        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 4)]
        [Display(Name = "Tipo Veiculo")]
        public string TipoVeiculo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 2)]
        [Display(Name = "Tipo Combustivel")]
        public string TipoCombustivel { get; set; }

        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        public string Imagem { get; set; }


        [Required(ErrorMessage = "O Campo {0} é requirido!")]
        [Display(Name = "Quilometragem")]
        [StringLength(10, ErrorMessage = "O campo {0} deve conter no minimo {2} e no max {1} caracteres.", MinimumLength = 1)]

        public int Km { get; set; }

         
        public string IdUser { get; set; }
         
        public ICollection<Abastecimento> Abastecimento { get; set; }



    }
}

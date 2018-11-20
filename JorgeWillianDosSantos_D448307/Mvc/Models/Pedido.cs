using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class Pedido
    {
        [Key]
        [DisplayName("Id do pedido")]
        public int IdPedido { get; set; }
        [Required]
        [DisplayName("Nome do medicamento")]
        public string NomeMedicamento { get; set; }
        [Required]
        [DisplayName("Quantidade de medicamento")]
        public int QtdeMedicamento { get; set; }
        [Required]
        [DisplayName("Código do cliente")]
        public int CodCliente { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Data da entrega")]
        public DateTime DataEntreg { get; set; }
    }
}
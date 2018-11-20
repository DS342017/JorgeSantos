using System;
using System.ComponentModel.DataAnnotations;

namespace JorgeWillianDosSantos_D448307.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string NomeMedicamento { get; set; }
        public int QtdeMedicamento { get; set; }
        public int CodCliente { get; set; }
        public DateTime DataEntreg { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTM2._0.Models
{
    public class CuentaBanco
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("numCuenta")]
        public string NumeroCuenta { get; set; }
        [Column("nombreTitular")]
        public string NombreTitular { get; set; }
        [Column("saldo")]
        public decimal Saldo { get; set; }
        [Column("tipoCuenta")]
        public string TipoCuenta { get; set; }


    }
}

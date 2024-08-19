using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitdPres.Modelos
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdCliente { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdTipoPrestamoId { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdGarantia { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdTipoGastosLegales { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }
        public int CantidadCuotas { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdTipoAmortizacion{ get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPagos { get; set; }
        public DateTime FechaFinalizacion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Abono { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Tasa { get; set; }

        public int FrecuenciaPago { get; set; }
        public int DiasGracia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MontoGastoLegal { get; set; }

        public List<Pagos> ListaPagos { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdEstadoPrestamo { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal PorcientoMora { get; set; }
    }
}

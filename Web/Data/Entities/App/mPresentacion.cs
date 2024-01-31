using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;

namespace Web.Data.Entities.App
{
    [Table("mPresentaciones")]
    public class mPresentacion: BaseEntity
    {
        /// <summary>
        ///     Gets or sets the alto.
        /// </summary>
        /// <value>The alto.</value>
        [DecimalPrecision]
        public decimal Alto { get; set; }

        /// <summary>
        ///     Gets or sets the ancho.
        /// </summary>
        /// <value>The ancho.</value>
        [DecimalPrecision]
        public decimal Ancho { get; set; }

        /// <summary>
        ///     Gets or sets the cantidad.
        /// </summary>
        /// <value>The cantidad.</value>
        public short Cantidad { get; set; }

        /// <summary>
        ///     Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the largo.
        /// </summary>
        /// <value>The largo.</value>
        [DecimalPrecision]
        public decimal Largo { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the peso.
        /// </summary>
        /// <value>The peso.</value>
        [DecimalPrecision]
        public decimal Peso { get; set; }

        /// <summary>
        ///     Gets the total dimension.
        /// </summary>
        /// <value>The total dimension.</value>
        [NotMapped]
        public decimal TotalDimension => Alto * Ancho * Largo;
    }
}
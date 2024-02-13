using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
   [Table("mTransportes")]
    public class mTransporte : BaseEntity
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the alto.
        /// </summary>
        /// <value>The alto.</value>
        [DecimalPrecision(10)]
        public decimal Alto { get; set; }

        /// <summary>
        ///     Gets or sets the ancho.
        /// </summary>
        /// <value>The ancho.</value>
        [Required]
        [DecimalPrecision(10)]
        public decimal Ancho { get; set; }

        /// <summary>
        ///     Gets or sets the capacidad.
        /// </summary>
        /// <value>The capacidad.</value>
        [Required]
        [DecimalPrecision(10)]
        public decimal Capacidad { get; set; }

        /// <summary>
        ///     Gets or sets the capacidad medida.
        /// </summary>
        /// <value>The capacidad medida.</value>
        [MaxLength(4)]
        [Required]
        public string CapacidadMedida { get; set; }

        /// <summary>
        ///     The dimension
        /// </summary>
        /// <value>The dimension.</value>
        [NotMapped]
        public decimal Dimension => Largo * Ancho * Alto;

        //′,M
        /// <summary>
        ///     Gets or sets the dimension medida.
        /// </summary>
        /// <value>The dimension medida.</value>
        [MaxLength(4)]
        [Required]
        public string DimensionMedida { get; set; }

        /// <summary>
        ///     Gets or sets the largo.
        /// </summary>
        /// <value>The largo.</value>
        [Required]
        [DecimalPrecision(10)]
        public decimal Largo { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        #endregion
    }
}
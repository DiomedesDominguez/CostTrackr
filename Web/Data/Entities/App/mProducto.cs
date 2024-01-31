using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;

namespace Web.Data.Entities.App
{
    [Table("mProductos")]
    public class mProducto:BaseEntity
    {
        /// <summary>
        ///     Gets or sets a value indicating whether [aplica impuesto].
        /// </summary>
        /// <value><c>true</c> if [aplica impuesto]; otherwise, <c>false</c>.</value>
        public bool AplicaImpuesto { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [aplica oferta].
        /// </summary>
        /// <value><c>true</c> if [aplica oferta]; otherwise, <c>false</c>.</value>
        public bool AplicaOferta { get; set; }

        /// <summary>
        ///     Gets or sets the codigo.
        /// </summary>
        /// <value>The codigo.</value>
        public string Codigo { get; set; } = string.Empty;

       
        /// <summary>
        ///     Gets or sets the impuesto.
        /// </summary>
        /// <value>The impuesto.</value>
        public virtual mImpuesto Impuesto { get; set; }

        /// <summary>
        ///     Gets or sets the impuesto identifier.
        /// </summary>
        /// <value>The impuesto identifier.</value>
        public long? ImpuestoId { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Precio { get; set; }

        /// <summary>
        ///     Gets or sets the presentacion.
        /// </summary>
        /// <value>The presentacion.</value>
        public virtual mPresentacion Presentacion { get; set; }

        /// <summary>
        ///     Gets or sets the presentacion identifier.
        /// </summary>
        /// <value>The presentacion identifier.</value>
        public long PresentacionId { get; set; }

        /// <summary>
        ///     Gets or sets the producto familia.
        /// </summary>
        /// <value>The producto familia.</value>
        public virtual mProductoFamilia ProductoFamilia { get; set; }

        /// <summary>
        ///     Gets or sets the producto familia identifier.
        /// </summary>
        /// <value>The producto familia identifier.</value>
        public long? ProductoFamiliaId { get; set; }
    }
}
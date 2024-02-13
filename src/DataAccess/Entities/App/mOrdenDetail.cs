using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
    [Table("mOrdenesDetails")]
    public class mOrdenDetail : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the cantidad.
        /// </summary>
        /// <value>The cantidad.</value>
        public long Cantidad { get; set; }

        /// <summary>
        ///     Gets or sets the descuento.
        /// </summary>
        /// <value>The descuento.</value>
        [DecimalPrecision]
        public decimal Descuento { get; set; }

        /// <summary>
        ///     Gets or sets the impuesto.
        /// </summary>
        /// <value>The impuesto.</value>
        [DecimalPrecision]
        public decimal Impuesto { get; set; }

        /// <summary>
        ///     Gets or sets the medida.
        /// </summary>
        /// <value>The medida.</value>
        public string Medida { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }

        /// <summary>
        ///     Gets or sets the orden.
        /// </summary>
        /// <value>The orden.</value>
        public virtual mOrden Orden { get; set; }

        /// <summary>
        ///     Gets or sets the orden identifier.
        /// </summary>
        /// <value>The orden identifier.</value>
        public long OrdenId { get; set; }

        /// <summary>
        ///     Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        [DecimalPrecision]
        public decimal Precio { get; set; }

        /// <summary>
        ///     Gets or sets the producto.
        /// </summary>
        /// <value>The producto.</value>
        public virtual mProducto Producto { get; set; }

        /// <summary>
        ///     Gets or sets the producto identifier.
        /// </summary>
        /// <value>The producto identifier.</value>
        public long ProductoId { get; set; }

        /// <summary>
        ///     Gets or sets the sub total.
        /// </summary>
        /// <value>The sub total.</value>
        [NotMapped]
        public decimal SubTotal => Cantidad * Precio - Descuento;

        /// <summary>
        ///     Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [NotMapped]
        public decimal Total => SubTotal + Impuesto;

        #endregion Properties
    }
}
namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

    [Table("mOfertasDetails")]
    public class mOfertaDetail : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the cantidad.
        /// </summary>
        /// <value>The cantidad.</value>
        public long Cantidad { get; set; }

        public string Codigo { get; set; }

        /// <summary>
        ///     Gets or sets the descuento.
        /// </summary>
        /// <value>The descuento.</value>
        [DecimalPrecision(scale: 2)]
        public decimal Descuento { get; set; }

        /// <summary>
        ///     Gets or sets the impuesto.
        /// </summary>
        /// <value>The impuesto.</value>
        [DecimalPrecision(scale: 2)]
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
        ///     Gets or sets the oferta.
        /// </summary>
        /// <value>The oferta.</value>
        public virtual mOferta Oferta { get; set; }

        /// <summary>
        ///     Gets or sets the oferta identifier.
        /// </summary>
        /// <value>The oferta identifier.</value>
        public long OfertaId { get; set; }

        /// <summary>
        ///     Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        [DecimalPrecision(scale: 2)]
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
        public decimal SubTotal
        {
            get { return Cantidad * Precio - Descuento; }
        }

        /// <summary>
        ///     Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [NotMapped]
        public decimal Total
        {
            get { return SubTotal + Impuesto; }
        }

        #endregion Properties
    }
}
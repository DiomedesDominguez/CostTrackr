using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNMOFT.CostTrackr.ViewModel;
public class OrdenDetailsViewModel : OrdenViewModel
{
    /// <summary>
    ///     Gets or sets the cantidad.
    /// </summary>
    /// <value>The cantidad.</value>
    public long Cantidad { get; set; }

    /// <summary>
    ///     Gets or sets the descuento.
    /// </summary>
    /// <value>The descuento.</value>
    public decimal Descuento { get; set; }

    /// <summary>
    ///     Gets or sets the impuesto.
    /// </summary>
    /// <value>The impuesto.</value>
    public decimal Impuesto { get; set; }

    /// <summary>
    ///     Gets or sets the medida.
    /// </summary>
    /// <value>The medida.</value>
    public string Medida { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    public string Nombre { get; set; } = string.Empty;


    /// <summary>
    ///     Gets or sets the precio.
    /// </summary>
    /// <value>The precio.</value>
    public decimal Precio { get; set; }

    /// <summary>
    ///     Gets or sets the producto.
    /// </summary>
    /// <value>The producto.</value>
    public string ProductoNombre { get; set; }

    /// <summary>
    ///     Gets or sets the producto identifier.
    /// </summary>
    /// <value>The producto identifier.</value>
    public long ProductoId { get; set; }

    /// <summary>
    ///     Gets or sets the sub total.
    /// </summary>
    /// <value>The sub total.</value>
    public decimal SubTotal => Cantidad * Precio - Descuento;

    /// <summary>
    ///     Gets or sets the total.
    /// </summary>
    /// <value>The total.</value>
    public decimal Total => SubTotal + Impuesto;
}
namespace DNMOFT.CostTrackr.ViewModel;
using Base;
public class OfertaDetailViewModel : BaseViewModel
{
    /// <summary>
    ///     Gets or sets the cantidad.
    /// </summary>
    /// <value>The cantidad.</value>
    public long Cantidad { get; set; }

    public string Codigo { get; set; } = string.Empty;
    public decimal Descuento { get; set; }
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

    public decimal Precio { get; set; }

    /// <summary>
    ///     Gets or sets the producto.
    /// </summary>
    /// <value>The producto.</value>
    public string ProductoNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the producto identifier.
    /// </summary>
    /// <value>The producto identifier.</value>
    public long ProductoId { get; set; }
    public decimal SubTotal
    {
        get { return Cantidad * Precio - Descuento; }
    }

    public decimal Total
    {
        get { return SubTotal + Impuesto; }
    }
}

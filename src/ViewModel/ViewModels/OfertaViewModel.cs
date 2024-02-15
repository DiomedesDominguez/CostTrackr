using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class OfertaViewModel : BaseViewModel
{
    /// <summary>
    ///     Gets or sets the cantidad.
    /// </summary>
    /// <value>The cantidad.</value>
    public uint Cantidad { get; set; }

    /// <summary>
    ///     Gets or sets the clasificacion cliente.
    /// </summary>
    /// <value>The clasificacion cliente.</value>
    public string ClasificacionClienteNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the clasificacion cliente identifier.
    /// </summary>
    /// <value>The clasificacion cliente identifier.</value>
    public long ClasificacionClienteId { get; set; }
    /// <summary>
    ///     Gets or sets the desde.
    /// </summary>
    /// <value>The desde.</value>
    public DateTime Desde { get; set; }

    /// <summary>
    ///     Gets or sets the details.
    /// </summary>
    /// <value>The details.</value>
    public virtual ICollection<OfertaDetailViewModel>? Details { get; set; }

    /// <summary>
    ///     Gets or sets the disponibles.
    /// </summary>
    /// <value>The disponibles.</value>
    public uint Disponibles { get; set; }

    /// <summary>
    ///     Gets or sets the hasta.
    /// </summary>
    /// <value>The hasta.</value>
    public DateTime? Hasta { get; set; }

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nota.
    /// </summary>
    /// <value>The nota.</value>
    public string Nota { get; set; } = string.Empty;
}

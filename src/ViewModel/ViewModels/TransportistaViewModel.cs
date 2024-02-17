using System.ComponentModel.DataAnnotations;

namespace DNMOFT.CostTrackr.ViewModel;

public class TransportistaViewModel
{
    /// <summary>
    ///     Gets or sets the anio transporte.
    /// </summary>
    /// <value>The anio transporte.</value>
    [Display(Name = "Año transporte")]
    [Range(0, 2500)]
    public short AnioTransporte { get; set; }

    /// <summary>
    ///     Gets or sets the cedula asistente1.
    /// </summary>
    /// <value>The cedula asistente1.</value>
    [MaxLength(11)]
    public string CedulaAsistente1 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the cedula asistente2.
    /// </summary>
    /// <value>The cedula asistente2.</value>
    [MaxLength(11)]
    public string CedulaAsistente2 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the cedula conductor.
    /// </summary>
    /// <value>The cedula conductor.</value>
    [MaxLength(11)]
    public string CedulaConductor { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the compania transporte.
    /// </summary>
    /// <value>The compania transporte.</value>
    public string CompaniaTransporteNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the compania transporte identifier.
    /// </summary>
    /// <value>The compania transporte identifier.</value>
    public long? CompaniaTransporteId { get; set; }

    /// <summary>
    ///     Gets or sets the condicion servicio.
    /// </summary>
    /// <value>The condicion servicio.</value>
    public string CondicionServicioNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the ficha.
    /// </summary>
    /// <value>The ficha.</value>
    [MaxLength(25)]
    public string Ficha { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the flota.
    /// </summary>
    /// <value>The flota.</value>
    [MaxLength(10)]
    public string Flota { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the GPS tracking number.
    /// </summary>
    /// <value>The GPS tracking number.</value>
    [MaxLength(23)]
    public string GpsTrackingNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the marca transporte.
    /// </summary>
    /// <value>The marca transporte.</value>
    public string MarcaTransporte { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the movil asistente1.
    /// </summary>
    /// <value>The movil asistente1.</value>
    [MaxLength(10)]
    public string MovilAsistente1 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the movil asistente2.
    /// </summary>
    /// <value>The movil asistente2.</value>
    [MaxLength(10)]
    public string MovilAsistente2 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    [Required]
    [MaxLength(100)]
    [MinLength(4)]
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nombre asistente1.
    /// </summary>
    /// <value>The nombre asistente1.</value>
    [MaxLength(100)]
    [MinLength(4)]
    public string NombreAsistente1 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the nombre asistente2.
    /// </summary>
    /// <value>The nombre asistente2.</value>
    [MaxLength(100)]
    [MinLength(4)]
    public string NombreAsistente2 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the personal.
    /// </summary>
    /// <value>The personal.</value>
    [MaxLength(10)]
    public string Personal { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the placa.
    /// </summary>
    /// <value>The placa.</value>
    [MaxLength(25)]
    public string Placa { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets a value indicating whether [tiene GPS].
    /// </summary>
    /// <value><c>true</c> if [tiene GPS]; otherwise, <c>false</c>.</value>
    public bool TieneGps { get; set; }

    /// <summary>
    ///     Gets or sets the transporte.
    /// </summary>
    /// <value>The transporte.</value>
    public string TransporteNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the transporte identifier.
    /// </summary>
    /// <value>The transporte identifier.</value>
    public long? TransporteId { get; set; }
}

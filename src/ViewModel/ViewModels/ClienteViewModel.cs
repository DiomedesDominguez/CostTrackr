using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ClienteViewModel : BaseDireccionViewModel
{
    public long ClasificacionClienteId { get; set; }
    [Required]
    public string CondicionPago { get; set; } = string.Empty;
    [MaxLength(19)]
    public string Codigo { get; set; } = string.Empty;
    public string Contacto { get; set; } = string.Empty;
    [Required]
    [MaxLength(23)]
    public string Documento { get; set; } = string.Empty;
    [MaxLength(75)]
    public string Email { get; set; } = string.Empty;
    public decimal LimiteCredito { get; set; }
    [Required]
    [MaxLength(40)]
    [MinLength(3)]
    public string Nombres { get; set; } = string.Empty;
    /// <summary>
    ///     Gets or sets the telefono1.
    /// </summary>
    /// <value>The telefono1.</value>
    [MaxLength(15)]
    public string Telefono1 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the telefono2.
    /// </summary>
    /// <value>The telefono2.</value>
    [MaxLength(15)]
    public string Telefono2 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the telefono3.
    /// </summary>
    /// <value>The telefono3.</value>
    [MaxLength(15)]
    public string Telefono3 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the tipo documento.
    /// </summary>
    /// <value>The tipo documento.</value>
    [Required]
    public string TipoDocumento { get; set; } = string.Empty;
    public string ClasificacionClienteNombre { get; set; } = string.Empty;
}

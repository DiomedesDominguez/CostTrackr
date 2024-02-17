using System.ComponentModel.DataAnnotations;
using DNMOFT.CostTrackr.ViewModel.Base;

namespace DNMOFT.CostTrackr.ViewModel;

public class ProveedorViewModel : BaseViewModel
{
    public bool AplicaRetencionImpuesto { get; set; }

    /// <summary>
    ///     Gets or sets the contacto.
    /// </summary>
    /// <value>The contacto.</value>
    [MaxLength(60)]
    public string Contacto { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the documento.
    /// </summary>
    /// <value>The documento.</value>
    public string Documento { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the email.
    /// </summary>
    /// <value>The email.</value>
    [MaxLength(150)]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the impuesto.
    /// </summary>
    /// <value>The impuesto.</value>
    public string ImpuestoNombre { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the impuesto identifier.
    /// </summary>
    /// <value>The impuesto identifier.</value>
    public long ImpuestoId { get; set; }

    /// <summary>
    ///     Gets or sets the nombre.
    /// </summary>
    /// <value>The nombre.</value>
    [Required]
    public string Nombre { get; set; } = string.Empty;


    public string Telefono1 { get; set; } = string.Empty;
    public string Telefono2 { get; set; } = string.Empty;
    public string Telefono3 { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the tipo documento.
    /// </summary>
    /// <value>The tipo documento.</value>
    public string TipoDocumento { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the tipo proveedor.
    /// </summary>
    /// <value>The tipo proveedor.</value>
    public string TipoProveedor { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the tipo proveedor identifier.
    /// </summary>
    /// <value>The tipo proveedor identifier.</value>
    public long TipoProveedorId { get; set; }
}

namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mProveedores")]
public class mProveedor : BaseDireccion
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
    public virtual mImpuesto? Impuesto { get; set; }

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
    public TipoDocumento TipoDocumento { get; set; }

    /// <summary>
    ///     Gets or sets the tipo proveedor.
    /// </summary>
    /// <value>The tipo proveedor.</value>
    public virtual mTipoProveedor? TipoProveedor { get; set; }

    /// <summary>
    ///     Gets or sets the tipo proveedor identifier.
    /// </summary>
    /// <value>The tipo proveedor identifier.</value>
    public long TipoProveedorId { get; set; }

}
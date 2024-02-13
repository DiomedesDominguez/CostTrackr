namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mClientes")]
public class mCliente : BaseDireccion
{

    /// <summary>
    ///     Gets or sets the clasificacion cliente.
    /// </summary>
    /// <value>The clasificacion cliente.</value>
    public virtual mClasificacionCliente? ClasificacionCliente { get; set; }

    /// <summary>
    ///     Gets or sets the clasificacion cliente identifier.
    /// </summary>
    /// <value>The clasificacion cliente identifier.</value>
    public long ClasificacionClienteId { get; set; }

    /// <summary>
    ///     Gets or sets the codigo.
    /// </summary>
    /// <value>The codigo.</value>
    [MaxLength(19)]
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the condicion pago.
    /// </summary>
    /// <value>The condicion pago.</value>
    [Required]
    public CondicionPago CondicionPago { get; set; }

    /// <summary>
    ///     Gets or sets the contacto.
    /// </summary>
    /// <value>The contacto.</value>
    public string Contacto { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the documento.
    /// </summary>
    /// <value>The documento.</value>
    [Required]
    [MaxLength(23)]
    public string Documento { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the email.
    /// </summary>
    /// <value>The email.</value>
    [MaxLength(75)]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the limite credito.
    /// </summary>
    /// <value>The limite credito.</value>
    [DecimalPrecision]
    public decimal LimiteCredito { get; set; }

    /// <summary>
    ///     Gets or sets the nombres.
    /// </summary>
    /// <value>The nombres.</value>
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
    public TipoDocumento TipoDocumento { get; set; }
}
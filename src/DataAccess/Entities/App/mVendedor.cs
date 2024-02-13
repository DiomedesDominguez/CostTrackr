namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

[Table("mVendedores")]
public class mVendedor : BaseEntity
{

    /// <summary>
    ///     Gets or sets the codigo.
    /// </summary>
    /// <value>The codigo.</value>
    [MaxLength(19)]
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the direccion.
    /// </summary>
    /// <value>The direccion.</value>
    [MaxLength(120)]
    public string Direccion { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the documento.
    /// </summary>
    /// <value>The documento.</value>
    [Required]
    [MaxLength(23)]
    [MinLength(8)]
    public string Documento { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the email.
    /// </summary>
    /// <value>The email.</value>
    [MaxLength(75)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Nombre { get; set; } = string.Empty;

    public string Telefono1 { get; set; } = string.Empty;
    public string Telefono2 { get; set; } = string.Empty;
    public string Telefono3 { get; set; } = string.Empty;

    [Required]
    public TipoDocumento TipoDocumento { get; set; }

}
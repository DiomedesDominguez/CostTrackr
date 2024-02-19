using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;


namespace DNMOFT.CostTrackr.DataAccess.Entities.Identity;
/// <summary>
/// Represents a custom role claim in the application.
/// </summary>
[Table("mRoleClaims")]
public class mRoleClaim : IdentityRoleClaim<long>
{
    /// <summary>
    /// Gets or sets the type of the claim.
    /// </summary>
    [Column(TypeName = "text")]
    [AllowNull]
    public override string ClaimType { get; set; }

    /// <summary>
    /// Gets or sets the value of the claim.
    /// </summary>
    [Column(TypeName = "text")]
    [AllowNull]
    public override string ClaimValue { get; set; }

    /// <summary>
    /// Gets or sets the client IP associated with the claim.
    /// </summary>
    [MaxLength(15), Column(TypeName = "varchar(15)")]
    [DefaultValue("'127.0.0.1'"), Required]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the date and time when the claim was created.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the claim.
    /// </summary>
    [Required, DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the state of the record.
    /// </summary>
    [Required, DefaultValue(1)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the date and time when the claim was last updated.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated the claim.
    /// </summary>
    [Required, DefaultValue(1)]
    public long LastUpdatedBy { get; set; }
}
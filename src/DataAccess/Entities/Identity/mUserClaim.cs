using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Enums;
using System.Diagnostics.CodeAnalysis;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
/// <summary>
/// Represents a user claim in the CostTrackr application.
/// </summary>
[Table("mUserClaims")]
public class mUserClaim : IdentityUserClaim<long>
{
    /// <summary>
    /// Gets or sets the type of the claim.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string ClaimType { get; set; }

    /// <summary>
    /// Gets or sets the value of the claim.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string ClaimValue { get; set; }

    /// <summary>
    /// Gets or sets the client IP associated with the claim.
    /// </summary>
    [MaxLength(15), Column(TypeName = "varchar(15)")]
    [Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the creation date of the claim.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the claim.
    /// </summary>
    [DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the state of the record associated with the claim.
    /// </summary>
    [DefaultValue(RecordState.Activo)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the last updated date of the claim.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated the claim.
    /// </summary>
    [DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="mUserClaim"/> class.
    /// </summary>
    public mUserClaim()
    {
        ClaimType = string.Empty;
    }
}

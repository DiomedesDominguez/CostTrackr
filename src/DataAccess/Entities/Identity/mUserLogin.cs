using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;


namespace DNMOFT.CostTrackr.DataAccess.Entities.Identity;
/// <summary>
/// Represents a user login entity in the database.
/// </summary>
[Table("mUserLogins")]
public class mUserLogin : IdentityUserLogin<long>
{
    /// <summary>
    /// Gets or sets the login provider.
    /// </summary>
    [Column(TypeName = "varchar(450)"), AllowNull]
    public override string LoginProvider { get; set; }

    /// <summary>
    /// Gets or sets the provider key.
    /// </summary>
    [Column(TypeName = "varchar(450)"), AllowNull]
    public override string ProviderKey { get; set; }

    /// <summary>
    /// Gets or sets the provider display name.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string ProviderDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the client IP.
    /// </summary>
    [MaxLength(15), Column(TypeName = "varchar(15)")]
    [Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the created date and time.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the entity.
    /// </summary>
    [DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the record state.
    /// </summary>
    [DefaultValue(RecordState.Activo)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the last updated date and time.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated the entity.
    /// </summary>
    [DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user login.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 0)]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the provider key expiration time.
    /// </summary>
    public DateTime? ProviderKeyET { get; set; }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;
namespace DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
/// <summary>
/// Represents a user token entity in the database.
/// </summary>
[Table("mUserTokens")]
public class mUserToken : IdentityUserToken<long>
{
    /// <summary>
    /// Gets or sets the login provider for the user token.
    /// </summary>
    [Column(TypeName = "varchar(450)")]
    public override string LoginProvider { get; set; }

    /// <summary>
    /// Gets or sets the name of the user token.
    /// </summary>
    [Column(TypeName = "varchar(450)")]
    public override string Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the user token.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string Value { get; set; }

    /// <summary>
    /// Gets or sets the client IP associated with the user token.
    /// </summary>
    [MaxLength(15), Column(TypeName = "varchar(15)")]
    [Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the creation date of the user token.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the token.
    /// </summary>
    [DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the state of the user token.
    /// </summary>
    [DefaultValue(RecordState.Activo)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the last updated date of the user token.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated the token.
    /// </summary>
    [DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user token.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 0)]
    public long Id { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="mUserToken"/> class.
    /// </summary>
    public mUserToken()
    {
        LoginProvider = string.Empty;
        Name = string.Empty;
        Value = string.Empty;
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;


namespace DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;

[Table("mUsersRoles")]
public class mUserRole : IdentityUserRole<long>
{
    /// <summary>
    /// Gets or sets the client IP address.
    /// </summary>
    [MaxLength(15), Column(TypeName = "varchar(15)")]
    [Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the creation date and time.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created the record.
    /// </summary>
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the state of the record.
    /// </summary>
    [DefaultValue(1)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the last update date and time.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated the record.
    /// </summary>
    [DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user role.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 0)]
    public long Id { get; set; }
}
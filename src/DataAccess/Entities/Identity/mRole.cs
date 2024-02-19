using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Identity;
/// <summary>
/// /// Represents a custom role entity in the application.
/// </summary>
[Table("mRoles")]
public class mRole : IdentityRole<long>
{
    /// <summary>
    /// Gets or sets the concurrency stamp for the role.
    /// </summary>
    [Column(TypeName = "text")]
    [AllowNull]
    public override string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Gets or sets the name of the role.
    /// </summary>
    [Column(TypeName = "varchar(256)")]
    [AllowNull]
    public override string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the normalized name of the role.
    /// </summary>
    [Column(TypeName = "varchar(256)"), MaxLength(256)]
    [AllowNull]
    public override string NormalizedName { get; set; } = string.Empty;

    #region Base Properties

    /// <summary>
    /// Gets or sets the unique identifier for the role.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 0)]
    public override long Id { get; set; }

    /// <summary>
    /// Gets or sets the client IP address associated with the role.
    /// </summary>
    [MaxLength(15), Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the creation date and time of the role.
    /// </summary>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the user ID of the role creator.
    /// </summary>
    [Required, DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the record state of the role.
    /// </summary>
    [Required, DefaultValue(1)]
    public RecordState RecordState { get; set; } = RecordState.Activo;

    /// <summary>
    /// Gets or sets the last updated date and time of the role.
    /// </summary>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the user ID of the last role updater.
    /// </summary>
    [Required, DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    #endregion

    #region Disposable

    private bool disposed = false;

    /// <summary>
    /// Releases the resources used by the role.
    /// </summary>
    /// <param name="disposing">A boolean value indicating whether the method is being called from the Dispose method.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                ClientIp = string.Empty;
            }
            disposed = true;
        }
    }

    /// <summary>
    /// Releases the resources used by the role.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="mRole"/> class.
    /// </summary>
    ~mRole()
    {
        Dispose(false);
    }

    #endregion
}
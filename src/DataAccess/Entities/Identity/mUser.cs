using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DNMOFT.CostTrackr.DataAccess.Enums;
using Microsoft.AspNetCore.Identity;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
/// <summary>
/// Represents a user entity in the application.
/// </summary>
[Table("mUsers")]
public class mUser : IdentityUser<long>, IDisposable
{
    /// <summary>
    /// Gets or sets the concurrency stamp for the user.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Gets or sets the email address for the user.
    /// </summary>
    [Column(TypeName = "varchar(128)"), AllowNull]
    public override string Email { get; set; }

    /// <summary>
    /// Gets or sets the normalized email address for the user.
    /// </summary>
    [Column(TypeName = "varchar(128)"), AllowNull]
    public override string NormalizedEmail { get; set; }

    /// <summary>
    /// Gets or sets the normalized user name for the user.
    /// </summary>
    [Column(TypeName = "varchar(128)"), AllowNull]
    public override string NormalizedUserName { get; set; }

    /// <summary>
    /// Gets or sets the password hash for the user.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the phone number for the user.
    /// </summary>
    [Column(TypeName = "varchar(15)"), AllowNull]
    public override string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the security stamp for the user.
    /// </summary>
    [Column(TypeName = "text"), AllowNull]
    public override string SecurityStamp { get; set; }

    /// <summary>
    /// Gets or sets the user name for the user.
    /// </summary>
    [Column(TypeName = "varchar(128)"), AllowNull]
    public override string UserName { get; set; }

    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string LastName { get; set; }

    #region Base Properties

    /// <summary>
    /// Gets or sets the unique identifier for the user.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 0)]
    public override long Id { get; set; }

    /// <summary>
    /// Gets or sets the client IP address for the user.
    /// </summary>
    [MaxLength(15), Required, DefaultValue("'127.0.0.1'")]
    public string ClientIp { get; set; } = "";

    /// <summary>
    /// Gets or sets the creation date and time for the user.
    /// </summary>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who created this user.
    /// </summary>
    [Required, DefaultValue(1)]
    public long CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the record state for the user.
    /// </summary>
    [Required, DefaultValue(1)]
    public RecordState RecordState { get; set; }

    /// <summary>
    /// Gets or sets the last update date and time for the user.
    /// </summary>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastUpdated { get; set; }

    /// <summary>
    /// Gets or sets the ID of the user who last updated this user.
    /// </summary>
    [Required, DefaultValue(1)]
    public long LastUpdatedBy { get; set; }

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="mUser"/> class.
    /// </summary>
    public mUser()
    {
        PhoneNumber = string.Empty;
        Email = string.Empty;
        UserName = string.Empty;
        NormalizedEmail = string.Empty;
        NormalizedUserName = string.Empty;
        PasswordHash = string.Empty;
        SecurityStamp = string.Empty;
        ConcurrencyStamp = string.Empty;
        Name = string.Empty;
        LastName = string.Empty;
        RecordState = RecordState.Activo;
    }

    #region Disposable

    private bool disposed = false;

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="mUser"/> class and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
    /// Releases all resources used by the <see cref="mUser"/> class.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="mUser"/> class.
    /// </summary>
    ~mUser()
    {
        Dispose(false);
    }

    #endregion
}
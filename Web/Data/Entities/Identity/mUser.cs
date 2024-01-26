
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using DNMOFT.CostTrackR.Web.Data.Enums;

namespace DNMOFT.CostTrackR.Web.Data.Entities.Identity
{
        [Table("mUsers")]
        public class mUser : IdentityUser<long>, IDisposable
        {
                [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "varchar(128)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string Email { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "varchar(128)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string NormalizedEmail { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "varchar(128)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string NormalizedUserName { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string PasswordHash { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "varchar(15)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string PhoneNumber { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string SecurityStamp { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                [Column(TypeName = "varchar(128)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
                public override string UserName { get; set; }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

                public string Name { get; set; }
                public string LastName { get; set; }

                #region Base Properties
                [Key]
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                [Column(Order = 0)]
                public override long Id { get; set; }
                [MaxLength(15), Required, DefaultValue("'127.0.0.1'")]
                public string ClientIp { get; set; }
                [Required]
                [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
                public DateTime Created { get; set; }
                [Required, DefaultValue(1)]
                public long CreatedBy { get; set; }
                [Required, DefaultValue(1)]
                public RecordState RecordState { get; set; }
                [Required]
                [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
                public DateTime LastUpdated { get; set; }
                [Required, DefaultValue(1)]
                public long LastUpdatedBy { get; set; }
                #endregion

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
                        RecordState = RecordState.Active;
                }


                #region Disposable
                private bool disposed = false;

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

                public void Dispose()
                {
                        Dispose(true);
                        GC.SuppressFinalize(this);
                }

                ~mUser()
                {
                        Dispose(false);
                }
                #endregion

        }
}
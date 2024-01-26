
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using DNMOFT.CostTrackR.Web.Data.Enums;

namespace DNMOFT.CostTrackR.Web.Data.Entities.Identity
{
    [Table("mUsers")]
    public class mUser: IdentityUser<long>,IDisposable
    {
        [Column(TypeName = "text")]
        public override string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
        [Column(TypeName = "varchar(128)")]
        public override string Email { get; set; } 
        [Column(TypeName = "varchar(128)")]
        public override string NormalizedEmail { get; set; } 
        [Column(TypeName = "varchar(128)")]
        public override string NormalizedUserName { get; set; } 
        [Column(TypeName = "text")]
        public override string PasswordHash { get; set; } 
        [Column(TypeName = "varchar(15)")]
        public override string PhoneNumber { get; set; } 
        [Column(TypeName = "text")]
        public override string SecurityStamp { get; set; } 
        [Column(TypeName = "varchar(128)")]
        public override string UserName { get; set; }
        
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
        [Required, DefaultValue(0)]
        public RecordState RecordState { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [Required, DefaultValue(1)]
        public long LastUpdatedBy { get; set; }
        #endregion


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
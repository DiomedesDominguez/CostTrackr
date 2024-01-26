using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using DNMOFT.CostTrackR.Web.Data.Enums;
using DNMOFT.CostTrackR.Web.Data.Interfaces;

namespace DNMOFT.CostTrackR.Web.Data.Entities.Identity
{
    [Table("mRoles")]
    public class mRole: IdentityRole<long>
    {
        [Column(TypeName = "text")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override string ConcurrencyStamp { get; set; } 
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        [Column(TypeName = "varchar(256)")]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override string Name { get; set; } 
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        [Column(TypeName = "varchar(256)"), MaxLength(256)]
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override string NormalizedName { get; set; } 
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

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

        ~mRole()
        {
            Dispose(false);
        }
        #endregion
        
    }
}
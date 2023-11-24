using System.ComponentModel.DataAnnotations.Schema;
namespace DNMOFT.CostTrackr.Web.Data.Entities.Identity
{
    using DNMOFT.CostTrackr.Web.Data.Enums;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using DNMOFT.CostTrackr.Web.Data.Interfaces;
    [Table("mUsersRoles")]
    public class mUserRole : IdentityUserRole<long>
    {
        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        [DefaultValue(1)]
        public long CreatedBy { get; set; }
        [DefaultValue(1)]
        public RecordState RecordState { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [DefaultValue(1)]
        public long LastUpdatedBy { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // called via myClass.Dispose(). 
                    // OK to use any private object references
                }
                // Release unmanaged resources.
                // Set large fields to null.                
                disposed = true;
            }
        }

        public void Dispose() // Implement IDisposable
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~mUserRole()
        {
            Dispose(false);
        }
    }
}
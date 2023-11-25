namespace DNMOFT.CostTrackr.Web.Data.Entities.Identity
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using DNMOFT.CostTrackr.Web.Data.Enums;
    using DNMOFT.CostTrackr.Web.Data.Interfaces;
    using Microsoft.AspNetCore.Identity;
    [Table("mUserLogins")]
    public class mUserLogin : IdentityUserLogin<long>, IBaseEntity
    {
        [Column(TypeName = "varchar(450)")]
        public override string LoginProvider { get; set; } 
        [Column(TypeName = "varchar(450)")]
        public override string ProviderKey { get; set; } 
        [Column(TypeName = "text")]
        public override string ProviderDisplayName { get; set; } 
        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; } 


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        [DefaultValue(1)]
        public long CreatedBy { get; set; }
        public RecordState RecordState { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
        [DefaultValue(1)]
        public long LastUpdatedBy { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
        [ForeignKey("UserId")]
        public virtual mUser User { get; set; }

        public DateTime? ProviderKeyET { get; set; }

        private bool disposed = false;

        public mUserLogin()
        {
            User = new mUser();
        }

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
        ~mUserLogin()
        {
            Dispose(false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.Web.Data.Enums;
using DNMOFT.CostTrackr.Web.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DNMOFT.CostTrackr.Web.Data.Entities.Identity
{

    [Table("mUsers")]
    public class mUser : IdentityUser<long>
    {
        [Column(TypeName = "text")]
        public override string ConcurrencyStamp { get; set; } 
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
        ~mUser()
        {
            Dispose(false);
        }
    }
}
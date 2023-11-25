using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.Web.Data.Enums;
using Microsoft.AspNetCore.Identity;
using DNMOFT.CostTrackr.Web.Data.Interfaces;
using System.Collections.Generic;

namespace DNMOFT.CostTrackr.Web.Data.Entities.Identity
{
    [Table("mRoles")]
    public class mRole : IdentityRole<long>
    {
        [Column(TypeName = "text")]
        public override string ConcurrencyStamp { get; set; } 
        [Column(TypeName = "varchar(256)")]
        public override string Name { get; set; } 
        [Column(TypeName = "varchar(256)"), MaxLength(256)]
        public override string NormalizedName { get; set; } 

        [MaxLength(15), Column(TypeName = "varchar(15)")]
        [DefaultValue("'127.0.0.1'"), Required]
        public string ClientIp { get; set; } 


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }


        [DefaultValue(1)]
        public long CreatedBy { get; set; }
        [Required]
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

        ~mRole() // the finalizer
        {
            Dispose(false);
        }
    }
}
using System.Diagnostics;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.Web.Data.Interfaces;
using DNMOFT.CostTrackr.Web.Data.Enums;

namespace DNMOFT.CostTrackr.Web.Data.Bases
{
    public class BaseEntity : IBaseEntity
    {
        [MaxLength(15), Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime Created { get; set; }
        [Required, DefaultValue(1)]
        public long CreatedBy { get; set; }
        [Required, DefaultValue(0)]
        public RecordState RecordState { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime LastUpdated { get; set; }
        [Required, DefaultValue(1)]
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

        ~BaseEntity() // the finalizer
        {
            Dispose(false);
        }
    }
}
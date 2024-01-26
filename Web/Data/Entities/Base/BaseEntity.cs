using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackR.Web.Data.Enums;
using DNMOFT.CostTrackR.Web.Data.Interfaces;

namespace DNMOFT.CostTrackR.Web.Data.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        #region Base Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
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

        ~BaseEntity()
        {
            Dispose(false);
        }
        #endregion
        
    }
}
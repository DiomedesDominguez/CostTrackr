using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Enums;
using DNMOFT.CostTrackr.DataAccess.Interfaces;

namespace DNMOFT.CostTrackr.DataAccess.Entities.Base
{
    /// <summary>
    /// Represents the base entity for all entities in the application.
    /// </summary>
    public class BaseEntity : IBaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier of the entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the client IP address associated with the entity.
        /// </summary>
        [MaxLength(15), Required, DefaultValue("'127.0.0.1'")]
        public string ClientIp { get; set; } = "127.0.0.1";

        /// <summary>
        /// Gets or sets the creation date and time of the entity.
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the user ID who created the entity.
        /// </summary>
        [Required, DefaultValue(1)]
        public long CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the state of the entity.
        /// </summary>
        [Required, DefaultValue(RecordState.Activo)]
        public RecordState RecordState { get; set; } = RecordState.Activo;

        /// <summary>
        /// Gets or sets the last modification date and time of the entity.
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the user ID who last modified the entity.
        /// </summary>
        [Required, DefaultValue(1)]
        public long LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated Sucursal.
        /// </summary>
        [DefaultValue(0)]
        public long SucursalId { get; set; }

        private bool disposed = false;

        /// <summary>
        /// Releases the resources used by the entity.
        /// </summary>
        /// <param name="disposing">A boolean indicating whether the method is being called from the Dispose method.</param>
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
        /// Releases the resources used by the entity.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the BaseEntity class.
        /// </summary>
        ~BaseEntity()
        {
            Dispose(false);
        }
    }
}

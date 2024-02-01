using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;

namespace Web.Data.Entities.App
{
    [Table("mTipoProveedores")]
    public class mTipoProveedor:BaseEntity
    {
        /// <summary>
        ///     Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        [MaxLength(120)]
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the impuesto.
        /// </summary>
        /// <value>The impuesto.</value>
        public virtual mImpuesto Impuesto { get; set; }

        /// <summary>
        ///     Gets or sets the impuesto identifier.
        /// </summary>
        /// <value>The impuesto identifier.</value>
        public long ImpuestoId { get; set; }
    }
}
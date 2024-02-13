using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
    [Table("mTiposProveedores")]
    public class mTipoProveedor : BaseEntity
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        [MaxLength(120)]
        public string Descripcion { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        #endregion
    }
}
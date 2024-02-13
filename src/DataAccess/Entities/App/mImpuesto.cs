using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
    [Table("mImpuestos")]
    public class mImpuesto : BaseEntity
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

        /// <summary>
        ///     Gets or sets the tasa.
        /// </summary>
        /// <value>The tasa.</value>
        [Required]
        [Range(0, 100)]
        public decimal Tasa { get; set; }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
    [Table("mClasificacionesClientes")]
    public class mClasificacionCliente : BaseEntity
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the codigo.
        /// </summary>
        /// <value>The codigo.</value>
        [MaxLength(15)]
        public string Codigo { get; set; }

        /// <summary>
        ///     Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        [MaxLength(550)]
        public string Descripcion { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Nombre { get; set; }

        #endregion
    }
}
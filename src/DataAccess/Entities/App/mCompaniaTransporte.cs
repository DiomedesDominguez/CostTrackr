using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
   [Table("mCompaniasTransportes")]
    public class mCompaniaTransporte : BaseEntity
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the codigo.
        /// </summary>
        /// <value>The codigo.</value>
        [MaxLength(7)]
        public string Codigo { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Nombre { get; set; }

        #endregion
    }
}
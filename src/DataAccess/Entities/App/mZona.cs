namespace DNMOFT.CostTrackr.DataAccess.Entities.App;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.DataAccess.Entities.Base;
using DNMOFT.CostTrackr.DataAccess.Enums;

   [Table("mZonas")]
    public class mZona : BaseEntity
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the coordenadas.
        /// </summary>
        /// <value>The coordenadas.</value>
        public DbGeometry Coordenadas { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [es predefinido].
        /// </summary>
        /// <value><c>true</c> if [es predefinido]; otherwise, <c>false</c>.</value>
        public bool EsPredefinido { get; set; }

        /// <summary>
        ///     Gets or sets the municipio.
        /// </summary>
        /// <value>The municipio.</value>
        public virtual mCiudad Municipio { get; set; }

        /// <summary>
        ///     Gets or sets the municipio identifier.
        /// </summary>
        /// <value>The municipio identifier.</value>
        public long? MunicipioId { get; set; }

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(60)]
        public string Nombre { get; set; }

        /// <summary>
        ///     Gets or sets the provincia.
        /// </summary>
        /// <value>The provincia.</value>
        public virtual mEstado Provincia { get; set; }

        /// <summary>
        ///     Gets or sets the provincia identifier.
        /// </summary>
        /// <value>The provincia identifier.</value>
        public long? ProvinciaId { get; set; }

        #endregion
    }
}
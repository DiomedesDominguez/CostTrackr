namespace DNMOFT.CostTrackr.ViewModel;

using System.ComponentModel.DataAnnotations;
using Base;

    public class ImpuestoViewModel : BaseViewModel
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        /// [MaxLength(120)]
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the tasa.
        /// </summary>
        /// <value>The tasa.</value>
        [Required]
        [Range(0, 100)]
        public decimal Tasa { get; set; }

        #endregion
    }

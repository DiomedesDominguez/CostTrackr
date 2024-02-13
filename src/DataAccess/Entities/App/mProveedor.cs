using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.App
{
   [Table("mProveedores")]
    public class mProveedor : BaseDireccion
    {
        #region Fields and properties

        /// <summary>
        ///     Gets or sets a value indicating whether [aplica retencion impuesto].
        /// </summary>
        /// <value><c>true</c> if [aplica retencion impuesto]; otherwise, <c>false</c>.</value>
        public bool AplicaRetencionImpuesto { get; set; }

        /// <summary>
        ///     Gets or sets the contacto.
        /// </summary>
        /// <value>The contacto.</value>
        [MaxLength(60)]
        public string Contacto { get; set; }

        /// <summary>
        ///     Gets or sets the documento.
        /// </summary>
        /// <value>The documento.</value>
        public string Documento { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [MaxLength(150)]
        public string Email { get; set; }

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

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required]
        public string Nombre { get; set; }


        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }

        /// <summary>
        ///     Gets or sets the tipo documento.
        /// </summary>
        /// <value>The tipo documento.</value>
        public TipoDocumento TipoDocumento { get; set; }

        /// <summary>
        ///     Gets or sets the tipo proveedor.
        /// </summary>
        /// <value>The tipo proveedor.</value>
        public virtual mTipoProveedor TipoProveedor { get; set; }

        /// <summary>
        ///     Gets or sets the tipo proveedor identifier.
        /// </summary>
        /// <value>The tipo proveedor identifier.</value>
        public long TipoProveedorId { get; set; }

        #endregion
    }
}
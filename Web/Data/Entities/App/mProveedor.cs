using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;
using Web.Data.Enums;

namespace Web.Data.Entities.App
{
    [Table("mProveedores")]
    public class mProveedor: BaseEntity
    {
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
        public string Contacto { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the documento.
        /// </summary>
        /// <value>The documento.</value>
        public string Documento { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        
        [DataType(DataType.PhoneNumber)]
        public string Telefono1 { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber)]
        public string Telefono2 { get; set; } = string.Empty;
        [DataType(DataType.PhoneNumber)]
        public string Telefono3 { get; set; } = string.Empty;

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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;

namespace Web.Data.Entities.App
{
    [Table("mMarcaProductos")]
    public class mMarcaProducto:BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        
    }
}
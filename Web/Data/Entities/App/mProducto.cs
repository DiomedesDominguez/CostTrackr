using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data.Entities.Base;

namespace Web.Data.Entities.App
{
    [Table("mProductos")]
    public class mProducto:BaseEntity
    {
        public string Codigo { get; set; }= string.Empty;
        public string Descripcion { get; set; }= string.Empty;
        public string Referencia { get; set; }
        public string Marca { get; set; }= string.Empty;
        public string Modelo { get; set; }= string.Empty;
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
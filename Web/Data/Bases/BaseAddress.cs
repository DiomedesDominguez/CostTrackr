using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DNMOFT.CostTrackr.Web.Data.Interfaces;

namespace DNMOFT.CostTrackr.Web.Data.Bases
{
    public class BaseAddress : BaseEntity, IAddress
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        [Required]
        public string Address { set; get; }
        public string Reference { get; set; }
        public string PlusCode { get; set; }
    }
}
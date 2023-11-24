using System;

namespace DNMOFT.CostTrackr.Web.Data.Interfaces
{
    public interface IAddress : IDisposable
    {
        decimal Latitude { get; set; }
        decimal Longitude { get; set; }
        string Address { set; get; }
        string Reference { get; set; }
        string PlusCode { get; set; }
    }
}
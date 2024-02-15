namespace DNMOFT.CostTrackr.ViewModel.Base;

using Interfaces;

public class BaseViewModel : IBaseViewModel
{
    public BaseViewModel()
    {
        LastModifiedAt = DateTime.Now;
    }
    public long Id { get; set; }
    public byte EstadoRegistro { get; set; }
    public DateTime LastModifiedAt { get; set; }
}
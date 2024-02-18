using DNMOFT.CostTrackr.ViewModel.Interfaces;

namespace DNMOFT.CostTrackr.ViewModel;

public class BaseJTableResult : IJTableResult
{
    public string Result { get; set; } = string.Empty;

    public BaseJTableResult()
    {
        Result = "OK";
    }
}

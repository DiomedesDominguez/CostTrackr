using DNMOFT.CostTrackr.ViewModel.Interfaces;

namespace DNMOFT.CostTrackr.ViewModel.Base;

public class JTableResultViewModel<TE>: BaseJTableResult
        where TE : class, IBaseViewModel, new()
{
public TE Record { get; set; } = new();
}

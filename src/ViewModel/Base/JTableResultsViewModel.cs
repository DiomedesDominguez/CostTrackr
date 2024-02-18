using DNMOFT.CostTrackr.ViewModel.Interfaces;

namespace DNMOFT.CostTrackr.ViewModel.Base;

public class JTableResultsViewModel<TE> : BaseJTableResult
    where TE : class, IBaseViewModel, new()
{
    public List<TE> Records { get; set; } = new();
        public long TotalRecordCount { get; set; }
}
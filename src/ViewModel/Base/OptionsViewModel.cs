using System.Collections;

namespace DNMOFT.CostTrackr.ViewModel.Base;

public class OptionsViewModel: IEnumerable<OptionViewModel>
{
    public string Result { get; set; } = string.Empty;
    private List<OptionViewModel> _options = new();

    public IEnumerator<OptionViewModel> GetEnumerator()
    {
        return _options.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(OptionViewModel option)
    {
        _options.Add(option);
    }
}
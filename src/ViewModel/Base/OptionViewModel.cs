namespace DNMOFT.CostTrackr.ViewModel.Base;

public class OptionViewModel
{
    /// <summary>
    ///     Gets or sets the display text.
    /// </summary>
    /// <value>The display text.</value>
    public string DisplayText { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    /// <value>The value.</value>
    public object? Value { get; set; } = null;
}

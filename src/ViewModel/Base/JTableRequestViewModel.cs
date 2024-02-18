namespace DNMOFT.CostTrackr.ViewModel.Base;

public class JTableRequestViewModel
{
        /// <summary>
        ///     Gets or sets the jt filter value.
        /// </summary>
        /// <value>The jt filter value.</value>
        public string jtFilterValue { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the jt identifier.
        /// </summary>
        /// <value>The jt identifier.</value>
        public long? jtId { get; set; }

        /// <summary>
        ///     Gets or sets the size of the jt page.
        /// </summary>
        /// <value>The size of the jt page.</value>
        public int jtPageSize { get; set; }

        /// <summary>
        ///     Gets or sets the jt sorting.
        /// </summary>
        /// <value>The jt sorting.</value>
        public string jtSorting { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the start index of the jt.
        /// </summary>
        /// <value>The start index of the jt.</value>
        public int jtStartIndex { get; set; }
}

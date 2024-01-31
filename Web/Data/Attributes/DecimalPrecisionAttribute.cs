namespace System.ComponentModel.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DecimalPrecisionAttribute: Attribute
    {
         /// <summary>
        ///     Initializes a new instance of the <see cref="DecimalPrecisionAttribute" /> class.
        /// </summary>
        /// <param name="precision">The precision.</param>
        /// <param name="scale">The scale.</param>
        public DecimalPrecisionAttribute(byte precision = 18, byte scale = 2)
        {
            Precision = precision;
            Scale = scale;
        }

        /// <summary>
        ///     Gets or sets the precision.
        /// </summary>
        /// <value>The precision.</value>
        public byte Precision { get; set; }

        /// <summary>
        ///     Gets or sets the scale.
        /// </summary>
        /// <value>The scale.</value>
        public byte Scale { get; set; }
    }
}
namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Label Messsages to be printed on the label when supported
    /// </summary>
    public class LabelMessages
    {
        /// <summary>
        /// The first line of the custom label message.
        /// Some carriers may prefix this line with something like "REF", "Reference", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference1 { get; set; }

        /// <summary>
        /// The second line of the custom label message.
        /// Some carriers may prefix this line with something like "REF", "Reference", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference2 { get; set; }

        /// <summary>
        /// The third line of the custom label message.
        /// Some carriers may prefix this line with something like "REF", "Reference", "Trx Ref No.", etc.
        /// </summary>
        public string? Reference3 { get; set; }
    }
}
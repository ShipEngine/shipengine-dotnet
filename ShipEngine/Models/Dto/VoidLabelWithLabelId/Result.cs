namespace ShipEngineSDK.VoidLabelWithLabelId.Result
{
    /// <summary>
    /// Voided label result.
    /// </summary>
    public class VoidLabelIdResult
    {
        /// <summary>
        /// Indicates whether the attempt to void the label was successful
        /// </summary>
        public bool Approved { get; set; }

        /// <summary>
        /// Message associated with the result of the void label attempt
        /// </summary>
        public string Message { get; set; }
    }
}
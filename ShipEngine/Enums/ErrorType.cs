namespace ShipEngineSDK
{
    /// <summary>
    /// The error_type field indicates the type of error that occurred. Think of this as a broad category of error.
    /// </summary>
    public enum ErrorType
    {

        /// <summary>
        /// There is a problem with your account. This may be your ShipEngine account or a third-party account.
        /// See the the error_source field to determine which account needs your attention.
        /// </summary>
        AccountStatus,

        /// <summary>
        /// A security error occurred.
        /// This will occur if your API key is invalid or expired, or if you attempt to perform an operation that is not permitted for your account.
        /// </summary>
        Security,

        /// <summary>
        /// Something is wrong with the API request.
        /// This may be a syntax error, missing a required field, or an illegal value or combinatio of values. This error type always means that some change needs to be made to the request before retrying.
        /// </summary>
        Validation,
        /// <summary>
        /// There was a business rule violation. Business rules are requirements or limitations of a system.
        /// </summary>
        BusinessRules,

        /// <summary>
        /// An unknown or unexpected error occurred in our system. Or an error occurred that has not yet been assigned a specific error_type. If you receive persistent system errors, then please contact our support or check our API status page to see if there's a known issue.
        /// </summary>/
        System
    }
}
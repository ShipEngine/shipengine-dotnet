namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// The type of this tax identifier.
    /// </summary>
    public enum IdentifierType
    {
        /// <summary>
        /// The tax identifier is a Value Added Tax.
        /// </summary>
        Vat,

        /// <summary>
        /// The tax identifier is an Economic Operators Registration and Identification Number (EORI).
        /// </summary>
        Eori,

        /// <summary>
        /// The tax identifier is a Social Security Number.
        /// </summary>
        SSN,

        /// <summary>
        /// The tax identifier is an Employer Identification Number (EIN).
        /// </summary>
        Ein,

        /// <summary>
        /// The tax identifier is a Tax Identification Number (TIN).
        /// </summary>
        Tin,

        /// <summary>
        /// The tax identifier is an Import One-Stop Shop (IOSS).
        /// </summary>
        Ioss,

        /// <summary>
        /// The tax identifier is a Permanent Account Number (PAN).
        /// </summary>
        Pan,

        /// <summary>
        /// The tax identifier is a Norwegian VAT On E-Commerce(VOEC).
        /// </summary>
        Voec
    }
}
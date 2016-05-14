namespace Rabbit.Uniquators
{
    public enum IdBase
    {
        /// <summary>
        /// Base16 encoding
        /// </summary>
        Hexadecimal,
        /// <summary>
        /// Base36 encoding; use of letters (upper case) with digits
        /// </summary>
        Hexatrigesimal,
        /// <summary>
        /// NewBase60 encoding, similar to Base62, excluding I, O, and l, but including _(underscore)
        /// </summary>
        Sexagesimal,
        /// <summary>
        /// Base62 encoding, using 0-9, A-Z, and a-z
        /// </summary>
        Duosexagesimal,
        /// <summary>
        /// A custom base which uses to generate shortest ID
        /// </summary>
        WebId
    }
}
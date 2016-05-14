namespace Rabbit.Uniquators
{
    public static class Characters
    {
        /// <summary>
        /// Numeric characters
        /// </summary>
        public const string Numbers = "0123456789";
        /// <summary>
        /// Upper alphabet characters
        /// </summary>
        public const string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// All characters for Base36 encoding
        /// </summary>
        public const string Hexatrigesimal = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// All characters for Base60 encoding
        /// </summary>
        public const string Sexagesimal = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz_";
        /// <summary>
        /// All characters for Base62 encoding
        /// </summary>
        public const string Duosexagesimal = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// All characters for short id
        /// https://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters
        /// </summary>
        public const string ShortIdTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!$()*+,-.:;@[]^_{}~";
    }
}
using System;

namespace Amadeus.Utilities
{
    /// <summary>
    /// Responsible for Encryption of scripts. Might be disposed of depending on usage and time.
    /// </summary>
    public sealed class EncryptionHandler
    {
        public static EncryptionHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<EncryptionHandler> _instance = new Lazy<EncryptionHandler>(() => new EncryptionHandler());

        private EncryptionHandler()
        {
        }
    }
}

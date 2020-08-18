using Amadeus.InterfacesForUtilities;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Amadeus.Utilities
{
    /// <summary>
    /// Responsible for Encryption of scripts. Might be disposed of depending on usage and time.
    /// </summary>
    public sealed class PgpEncryptionHandler : IPgpEncryptionHandler
    {
        public static PgpEncryptionHandler Instance { get { return _instance.Value; } }
        private static readonly Lazy<PgpEncryptionHandler> _instance = new Lazy<PgpEncryptionHandler>(() => new PgpEncryptionHandler());
        private PgpEncryptionHandler()
        {
        }

        public void Encrypt(string path)
        {

        }

        public void Decrypt(string path)
        {

        }
    }
}

namespace Amadeus.InterfacesForUtilities
{
    /// <summary>
    /// Function names are self-explanatory
    /// </summary>
    interface IPgpEncryptionHandler
    {
        void Encrypt(string path);
        void Decrypt(string path);
    }
}

using System.Security.Cryptography;
using System.Text;

namespace source._0500._535;

public class Codec
{
    private byte[] _secretKey = Encoding.UTF8.GetBytes("1234567890123456");
    private byte[] _commonIV = Encoding.UTF8.GetBytes("1234567890123456");


    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        byte[] plaintextBytes = Encoding.UTF8.GetBytes(longUrl);

        using Aes aes = Aes.Create();
        aes.Key = _secretKey;
        aes.IV = _commonIV;

        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

        using MemoryStream ms = new();
        using (CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write))
        {
            cs.Write(plaintextBytes, 0, plaintextBytes.Length);
            cs.Close();
        }

        byte[] encryptedBytes = ms.ToArray();

        return Convert.ToBase64String(encryptedBytes);
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        byte[] encryptedBytes = Convert.FromBase64String(shortUrl);

        using Aes aes = Aes.Create();
        aes.Key = _secretKey;
        aes.IV = _commonIV;

        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

        using MemoryStream ms = new(encryptedBytes);
        using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
        using StreamReader sr = new(cs);

        return sr.ReadToEnd();
    }
}
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
internal static class Encryption
{
	private const int int_0 = 256;

	public static string Encrypt(string plainText, string passPhrase, string salt = "tu89geji340t89u2")
	{
		byte[] bytes = Encoding.UTF8.GetBytes(salt);
		byte[] bytes2 = Encoding.UTF8.GetBytes(plainText);
		byte[] bytes3 = new PasswordDeriveBytes(passPhrase, null).GetBytes(32);
		ICryptoTransform transform = new RijndaelManaged
		{
			Mode = CipherMode.CBC
		}.CreateEncryptor(bytes3, bytes);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes2, 0, bytes2.Length);
		cryptoStream.FlushFinalBlock();
		byte[] inArray = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(inArray);
	}

	public static string Decrypt(string cipherText, string passPhrase, string salt = "tu89geji340t89u2")
	{
		try
		{
			byte[] bytes = Encoding.ASCII.GetBytes(salt);
			byte[] array = Convert.FromBase64String(cipherText);
			byte[] bytes2 = new PasswordDeriveBytes(passPhrase, null).GetBytes(32);
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(bytes2, bytes);
			MemoryStream memoryStream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			byte[] array2 = new byte[array.Length];
			int count = cryptoStream.Read(array2, 0, array2.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
		catch (Exception)
		{
			return null;
		}
	}
}

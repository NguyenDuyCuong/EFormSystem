using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Common.Encryption
{
    /// <summary>
    /// The default encryption service.
    /// </summary>
    public class EncryptionService : IEncryptionService
    {
        /// <summary>
        /// Encrypts the specified value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        public byte[] Encrypt(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var sha = System.Security.Cryptography.SHA1.Create();
                return sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(value));
            }

            return new byte[] { };
        }
    }
}

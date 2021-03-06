// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Diagnostics;

namespace System.Security.Cryptography
{
    internal partial class RandomNumberGeneratorImplementation
    {
        private static unsafe void GetBytes(byte* pbBuffer, int count)
        {
            Debug.Assert(count > 0);

            int res = Interop.GetCryptographicallySecureRandomBytes(pbBuffer, count);
            if (res != 0)
                throw new CryptographicException();
        }
    }
}

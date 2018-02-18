using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FireEmblemRPS
{
    public class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[4];
            _generator.GetBytes(randomNumber);

            int randomValue = BitConverter.ToInt32(randomNumber, 0);

            return randomValue;
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

namespace CodeProject_B1
{
    internal class HashCode
    {
        public String PassHash(String password)
        {   
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(password));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }
            return returnValue.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen
{
    /* Page: http://www.crackmes.de/users/borismilner/4n006135/ */
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            uint username = uint.Parse(Console.ReadLine());

            StringBuilder key = new StringBuilder();

            #region Prefix
            string binaryUsername = Convert.ToString(username, 2); //converts to binary
            uint cFlag = uint.Parse(binaryUsername[binaryUsername.Length - 1].ToString());

            if (cFlag == 1)
                key.Append('*');
            else
                key.Append('O');

            if (username < 2976579765)
                key.Append('*');
            else
                key.Append('O');

            key.Append('*');
            #endregion


            uint ebx = username;
            for(uint ecx = 1; ecx < 29; ecx++)
            {
                ebx /= 2;
                uint edx = 0;
                uint esi = 26;
                edx = ebx % esi;

                if (ecx%2 == 0)
                {
                    edx += 65;
                }
                else
                {
                    edx += 97;
                }

                key.Append(Convert.ToChar(edx));
            }
            key.Append('O');
            Clipboard.SetText(key.ToString());
            Console.Write("Key: ");
            Console.Write(key.ToString());
            Console.Write(" [Copied to clipboard!] ");
            Console.WriteLine();
        }
    }
}

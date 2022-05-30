using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vips = new HashSet<string>();
            var regulars = new HashSet<string>();

            string cmd;

            while ((cmd = Console.ReadLine()) != "PARTY")
            {
                char vipOrNot = cmd[0];
                if (char.IsDigit(vipOrNot))
                {
                    vips.Add(cmd);
                }
                else
                {
                    regulars.Add(cmd);
                }
            }
            while ((cmd = Console.ReadLine()) != "END")
            {
                vips.Remove(cmd);
                regulars.Remove(cmd);
            }

            Console.WriteLine(vips.Count + regulars.Count);
            foreach (var vip in vips)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regulars)
            {
                Console.WriteLine(regular);
            }
        }
    }
}

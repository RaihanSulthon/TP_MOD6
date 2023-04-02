using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_KPL_FantasticFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302204056 d = new DataMahasiswa_1302204056();

            d.ReadJSON();

            Console.WriteLine();

            TeamMembers_1302204056 s = new TeamMembers_1302204056();

            s.ReadJSON();

        }
    }
}
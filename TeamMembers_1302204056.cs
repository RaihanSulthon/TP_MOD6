using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_KPL_FantasticFive
{
    class TeamMembers_1302204056
    {
        public TeamMember[] members { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_2_nim.json" ;

            string jsonString = File.ReadAllText(fileName) ;

            TeamMembers_1302204056 jsonData = JsonSerializer.Deserialize<TeamMembers_1302204056>(jsonString) ;

            this.members = jsonData.members ;

            this.info() ;
        }

        public void info()
        {
            Console.WriteLine("Team member list:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " (" + this.age + " " + this.gender + ")");
        }
    }
}

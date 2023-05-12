using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseCase2.Codes
{
    internal class Mekaniker : PersonInfo
    {
        public PersonInfo Person { get; set; }

        public Mekaniker(string firstName, string lastName, int tlf)  : base(firstName, lastName, tlf)
        {
            
        }
        public Mekaniker()
        {

        }
        public override List<KøreTøj> Søg(string? firstName, string? lastName, List<KøreTøj> køretøjList)
        {
            return køretøjList.Where(x => x.KøretøjMekaniker.FirstName == firstName && x.KøretøjMekaniker.LastName == lastName).ToList();
        }
    }
}

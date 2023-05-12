using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseCase2.Codes;

internal class Kunden : PersonInfo
{
    public Kunden(string firstName, string lastName, int tlf) : base(firstName, lastName, tlf)
    {

    }

    public Kunden()
    {

    }
    public override List<KøreTøj> Søg(string? firstName, string? lastName, List<KøreTøj> køretøjList)
    {

        List<KøreTøj> lst = new List<KøreTøj>();
        foreach (KøreTøj item in køretøjList)
        {
            if (item.KøretypeEjer.FirstName == firstName && item.KøretypeEjer.LastName == lastName)
            {
                string? mekanikerFornavn = item.KøretøjMekaniker.FirstName;
                string? mekanikerEfternavn = item.KøretøjMekaniker.LastName;
                lst = køretøjList.Where(x => x.KøretøjMekaniker.FirstName == mekanikerFornavn && x.KøretøjMekaniker.LastName == mekanikerEfternavn).ToList();
                break;
            }
        }
        if(lst.Count == 0)
        {
            throw new Exception("Der er ikke registrert nogle køretøjer");
        }
        return lst;
    }


}

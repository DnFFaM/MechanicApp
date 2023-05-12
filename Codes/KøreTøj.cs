using ØvelseCase2.Codes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseCase2.Codes;

internal class KøreTøj
{
    public string? NummmerPlade { get; set; }

    public string? Mærke { get; set; }
    public string? Model { get; set; }
    public string? RegistreringsÅrgang { get; set; }
    public EnumKøreTyper KøretøjTyper { get; set; }
    public Mekaniker? KøretøjMekaniker { get; set; }
    public Kunden? KøretypeEjer {get; set; }
    public List<KøreTøj> KøretøjList { get; set; }

    public KøreTøj(string? nummmerPlade, string? mærke, string? model, string? registreringsÅrgang, EnumKøreTyper køretøjTyper, Kunden? køretypeEjer )
    {
        NummmerPlade = nummmerPlade;
        Mærke = mærke;
        Model = model;
        RegistreringsÅrgang = registreringsÅrgang;
        KøretøjTyper = køretøjTyper;
        if (køretøjTyper == EnumKøreTyper.Bil)
        {
            KøretøjMekaniker = new("Abdol", "Hasan", 9171717);
        }

        else if (køretøjTyper == EnumKøreTyper.MotroCykel)
        {
            KøretøjMekaniker = new("Peter", "Petersen", 71919191);

        }
        else if (køretøjTyper == EnumKøreTyper.LastBil)
        {
            KøretøjMekaniker = new("Hans", "Hansen", 61001413);
        }
        

        KøretypeEjer = køretypeEjer;
        
    }
    public KøreTøj()
    {
        KøretøjList = new();
    }
}

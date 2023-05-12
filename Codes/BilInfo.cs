using ØvelseCase2.Codes.Enum;

namespace ØvelseCase2.Codes
{
    internal class BilInfo
    {
        public string? NummerPlade { get; set; }
        public string? Mærke { get; set; }
        public string? Model { get; set; }
        Enum.EnumKøreTyper EnumKøreTyper { get; set; }
        public string? RegistreringsÅrgang { get; set; }
        public string? Type { get; set; }

        public BilInfo(string? nummerPlade, string? mærke, string? model, EnumKøreTyper EnumKøretyper, string? registreringsÅrgang, string? type)
        {
            NummerPlade = nummerPlade;
            Mærke = mærke;
            Model = model;
            EnumKøreTyper = EnumKøretyper;
            RegistreringsÅrgang = registreringsÅrgang;
            Type = type;
        }
    }
}

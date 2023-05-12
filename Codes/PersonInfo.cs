using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseCase2.Codes
{
    internal abstract class PersonInfo
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Tlf { get; set; }

        public PersonInfo(string? firstName, string? lastName, int tlf)
        {
            FirstName = firstName;
            LastName = lastName;
            Tlf = tlf;
        }
        public PersonInfo()
        {

        }
        public abstract List<KøreTøj> Søg(string? firstName, string? lastName, List<KøreTøj> køretøjList);
        
    }
} 

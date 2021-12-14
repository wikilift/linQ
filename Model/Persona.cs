using System.Diagnostics;
namespace linQ.Model
{
    public class Persona
    {
        [DebuggerDisplay("{Name}")]
        public string Name {get;set;}="SS";

        public int Age{get;set;}

        public bool Single{get;set;}
        public DateTime dateOfStart{get;set;}
        public List<string>Phones=new List<string>();
        public int EmployeeId{get;set;}
    }
}
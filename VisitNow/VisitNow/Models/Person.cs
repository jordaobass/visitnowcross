using System;

namespace VisitNow.Models
{
    public class Person
    {
        public int Id { get; set; }
        public long Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfileImage { get; set; }
        public string Name { get; set; }
        public bool IsChild { get; set; }
        public string ShortName
        {
            get
            {
                if(!String.IsNullOrEmpty(Name))
                {
                    string[] arrayName = Name.Split(' ');
                    return arrayName[0];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

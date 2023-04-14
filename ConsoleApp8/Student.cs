using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Student:IcodeAcedemy
    {
        private string _name;
        private string _email;
        private string _pasword;
        private string _surname;
       
        static int Count { get; set; } = 0;
        public int Id { get; init; }
        public string Name 
        {
            get
            {
                return _name;
            }
    set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }
            }
        }
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length>= 3)
                {
                    _surname = value;
                }

            }
        }
        public string CodeEmail 
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }
            }
        }

        public Student(string name, string surname)
        {

            Name = name;
            Surname = surname;
            Count++;
            Id = Count;
            GenerateEmail();

        }

        public void Capitalize()
        {
            Name = char.ToUpper(Name[0]) + Name.Substring(1);

            Surname = char.ToUpper(Surname[0]) + Surname.Substring(1);

            
        }
        public void GenerateEmail()
        {

            string email = Name.ToLower() + "." + Surname.ToLower() + Id + "@code.edu.az";
            CodeEmail = email;
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionale_log_In
{
    class modelStudent
    {
        private string _id;
        private string gender;
        private string title;
        private string first;
        private string last;
        private int matricola;
        private string street;
        private string city;
        private string state;
        private string country;
        private string postcode;
        private string email;
        private string username;
        private string password;
        private int age;
        private string cell;
        private string nat;
        private string isAdmin;
        public modelStudent() { }

        public string Id { get => _id; set => _id = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Title { get => title; set => title = value; }
        public string First { get => first; set => first = value; }
        public string Last { get => last; set => last = value; }
        public int Matricola { get => matricola; set => matricola = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Age { get => age; set => age = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Nat { get => nat; set => nat = value; }
        public string IsAdmin { get => isAdmin; set => isAdmin = value; }
      
    }
}

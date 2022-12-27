using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApplication
{

    public class User
    {
        public User(int id, string name, string password, string question, string answer)
        {
            Id = id;
            Name = name;
            Password = password;
            Question = question;
            Answer = answer;
        }

        public User(string name, string password, string question, string answer)
        {
            Name = name;
            Password = password;
            Question = question;
            Answer = answer;
        }

        public int Id { get; set; }

        public string Name { get; set; }    

        public string Password { get; set; }    

        public string Question { get; set; }    

        public string Answer { get; set; }
    
    }


}

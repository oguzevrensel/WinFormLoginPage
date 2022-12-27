using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApplication
{
    public class UserProcess
    {

        static UserProcess userProcess;

        private UserProcess()
        {
        }

        List<User> users = new List<User>()
        {
            new User(1,"oguzevrensel","12345","En sevdiği araba","Mercedes"),
            new User(2,"uzaypardo","12345","En sevdiği araba","Mercedes"),
            new User(3,"batuhankralım","12345","En sevdiği araba","Mercedes"),
            new User(4,"oguzhancaner","12345","En sevdiği araba","Mercedes"),
        };

        public string AddUser(User user)
        {
            try
            {
                if(!IsUserComplete(user))
                {
                    return "Kullanıcı hatalıdır";
                }

                if(!IsPasswordComplete(user.Password))
                {
                    return "Şifre yeteri kadar güvenli değil";
                }

                users.Add(user);
                return user.Name + " olarak kaydoldunuz";
            }

            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string UpdatePassword(int userId, string password)
        {
            try
            {
                if(!IsPasswordComplete(password))
                {
                    return "Şifre yeteri kadar güvenli değil";
                }
                foreach (var user in users)
                {
                    if(user.Id == userId)
                    {
                        user.Password = password;
                        return "Şifre Başarıyla Güncellendi";
                    }
                    
                }
                return "Aradığınız kullanıcı bulunamadı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public bool LoginControl (string userName, string password)
        {
            try
            {
                foreach (var user in users)
                {
                    if(user.Name == userName && user.Password == password)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch 
            {

                return false;
            }
        }

        public bool IsUserComplete(User user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Name) ||
                    string.IsNullOrEmpty(user.Password) ||
                    string.IsNullOrEmpty(user.Question) ||
                    string.IsNullOrEmpty(user.Answer) 
                    )
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
            catch 
            {

                return false;
            }
        }

        bool IsPasswordComplete(string password)
        {
            try
            {
                if(string.IsNullOrEmpty(password) || 
                  password.Length < 7 || 
                  password.Contains("12345"))
                {
                    return false;
                }

                return true;

            }
            catch 
            {

                return false;
            }
        }

        public int GetUserIdByUserName(string userName)
        {
            foreach (var item in users)
            {
                if(item.Name == userName)
                {
                    return item.Id;
                }
            }
            return -1;
        }

        public string GetQuestionByUserId(int userId)
        {
            foreach (var item in users)
            {
                if(item.Id == userId)
                {
                    return item.Question;
                }

            }
            return "";
        }

        public bool IsAnswerTrue(int userId, string answer)
        {
            foreach (var item in users)
            {
                if(item.Id == userId && item.Answer == answer)
                {
                    return true;
                }
            }
            return false;
        }

        public static UserProcess GetInstance()
        {
            if (userProcess == null)
            {
                userProcess = new UserProcess();
            }
            return userProcess;
        }



    }
}

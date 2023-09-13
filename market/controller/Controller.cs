using market.dao;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.controller
{
      
    public class Controller
    {
        Repository repository;

        public Controller()
        {

            repository= new Repository();
        }

        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre)) 
            {
                 result = repository.login(kullaniciAdi,sifre);
               return result;
            
            }
            else
            {

                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
            

        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTable();

            return loginTableList;

        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSouru, string guvenlikCevabi)
        {
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikCevabi) && !string.IsNullOrEmpty(guvenlikSouru))
            {

                LoginStatus result =repository.doAuthentication(kullaniciAdi, guvenlikSouru, guvenlikCevabi);

                if(result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {

               return LoginStatus.eksikParametre;
            }
            
        }

        public Repository GetRepository()
        {
            return repository;
        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {

                return repository.changePassword(kullaniciAdi.Trim(), sifre);

            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public string checkEmailAddress(string kullaniciAdi)
        {

           return repository.checkEmailAddress(kullaniciAdi);
        }
    }
}

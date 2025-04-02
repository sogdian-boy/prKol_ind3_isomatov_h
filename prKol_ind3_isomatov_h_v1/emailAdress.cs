using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace prKol_ind3_isomatov_h_v1
{
    public class emailAdress
    {
        string[] fullAdress;
        string login;
        string domen;
        public static ArrayList emails = new ArrayList();
        public emailAdress(string adress)
        {
            fullAdress = adress.Split('@');
            login = fullAdress[0];
            domen = fullAdress[1];
            emails.Add(GetFullAdress());
        }
        public emailAdress(string log, string dom)
        {
            login = log;
            domen = dom;
            fullAdress = new string[2] { login, domen };
            emails.Add(GetFullAdress());
        }
        public void SetFullAdress(string adress)
        {
            fullAdress = adress.Split('@');
        }
        public void SetLogin(string log)
        {
            login = log;
            fullAdress[0] = login;
        }
        public void Setdomen(string dom)
        {
            domen = dom;
            fullAdress[1] = domen;
        }
        public string GetFullAdress()
        {
                return $"{fullAdress[0]}@{fullAdress[1]}";
        }
        public string GetLogin()
        {
                return login;
        }
        public string GetDomen()
        {
                return domen;
        }


    }
}

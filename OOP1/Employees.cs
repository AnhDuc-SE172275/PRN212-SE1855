using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Employee
    {
        #region Nhóm các Employee
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        public Employee()
        {
            this._id = 1;
            Id_card = "0000";
            this._name = "Obama";
        }

        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card= _id_card;
            this._name= _name;
            Email = _email;
            phone = _phone;
        }

        public int Id 
        { 
            get { return _id; }
            set { _id = value; } 
        }
        public string Id_card { 
            get { return _id_card; } 
            set { _id_card = value; } 
        }
        public string Name {
            get { return _name; } 
            set { _name = value; } 
        }
        public string Email { 
            get { return _email ; }
            set { _email = value; }
        }
        public string phone { 
            get { return _phone; } 
            set { _phone = value; } 
        }
        public void PrintInfor()
        {
            string msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{phone}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            string msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{phone}";
            return msg;
        }
    }
}

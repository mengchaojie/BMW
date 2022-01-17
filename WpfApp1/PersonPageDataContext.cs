using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class PersonPageDataContext:NotifyBase
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; Notify(); }
        }

        private string _QQCode { get; set; }

        public string QQCode
        {
            get { return _QQCode; }
            set { _QQCode = value; Notify(); }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; Notify(); }
        }

        public string _company { set; get; }

        public string Company
        {
            get { return _company; }
            set { _company = value; Notify(); }
        }

        public PersonPageDataContext()
        {
            Name = "MengChaoJie";
            QQCode = "3387024117";
            Address = "China";
            Company = "Atsw.Ltd.Com.KS";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using System.Windows;

namespace WpfApp1
{
    public class DataContext:NotifyBase
    {
        private string _welcomeString;

        public string WelcomeString
        {
            get { return _welcomeString; }
            set { _welcomeString = value; Notify(); }
        }

        private string _titleBackString;

        public  string TitleBackString
        {
            get { return _titleBackString; }
            set { _titleBackString = value; Notify(); }
        }


        private UserLogin _userLogin;

        public UserLogin UserLogin
        {
            get { return _userLogin; }
            set { _userLogin = value; Notify(); }
        }


        private string _pageName;

        public string PageName
        {
            get { return _pageName; }
            set { _pageName = value; Notify(); }
        }


        public CommandBase SwitchCommand { get; set; }

        public DataContext()
        {
            WelcomeString = "Welcome to the motor home Super practical Car";
            TitleBackString = "Car purchase can enjoy ten thousand yuan gift subsidy and make a magic world";
            UserLogin = new UserLogin();
            UserLogin.UserName = "";
            UserLogin.Password = "";

            SwitchCommand = new CommandBase();
            SwitchCommand.DoCanExcute = new Func<object, bool>(ReturnEnable);
            SwitchCommand.DoExcute = new Action<object>(DoWork);

            PageName = "PersonPage.xaml";
        }

        public bool ReturnEnable(object obj)
        {
            return true;
        }

        public void DoWork(object obj)
        {
            if (obj == null) return;
            string strText = obj as string;
            switch(strText)
            {
                case "Personal":
                    PageName = "PersonPage.xaml";
                    break;
                case "Employees":
                    PageName = "EmployeesPage.xaml";
                    break;
            }
        }
    }

}

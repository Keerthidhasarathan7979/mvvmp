using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVMCommon;

namespace MVVM.Viewmodel
{
  

    public class RegisterViewModel:HelperMVVM
    {

        //private string _name;

        //public string name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        OnProperty();
        //    }
        //}


        //private string _email;

        //public string email
        //{
        //    get { return _email; }
        //    set
        //    {
        //        _email = value;
        //        OnProperty();
        //    }
        //}



        //private string _password;

        //public string password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        _password = value;
        //        OnProperty();
        //    }
        //}

        //private int _phone;

        //public int phone
        //{
        //    get { return _phone; }
        //    set
        //    {
        //        _phone = value;
        //        OnProperty();
        //    }
        //}





        //private string _address;
        //public string address
        //{
        //    get { return _address; }
        //    set
        //    {
        //        _address = value;
        //        OnProperty();
        //    }
        //}




        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Phone { get; set; }

        public string Workstatus { get; set; }

        public string Address { get; set; }

        public ICommand RegisterButtonClick { get; set; }
        public ICommand UpdateButtonClick { get; set; }
        public ICommand DeleteButtonClick { get; set; }

        public ICommand GetDataCommand { get; set; }

        public RegisterViewModel()

        {
            name = "Keerthi";
            email = "Subu@gmail.com";
            password = "sakthi";
            phone = 8508050;
            address = "Tirupur";
            RegisterButtonClick = new RelayCommand(RegisterData);
            UpdateButtonClick = new RelayCommand(UpdateData);
            DeleteButtonClick = new RelayCommand(DeleteData);
            GetDataCommand = new RelayCommand(GetData);


        }
        public void RegisterData()
        {
           
            
        }
        public void UpdateData()
        {

        }

        public void DeleteData()
        {
           
        }

        public void GetData()
        {

            name = "sakthi";
            email = "keerthi@gmail.com";
            password = "subu";
            phone = 96779398;
            address = "Coimbatore";
        }

    }

    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action execute;
     

        public RelayCommand(Action execute1)
        {
            this.execute = execute1;
        }

      

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute.Invoke();
        }
    }
}

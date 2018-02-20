using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XForms.CustomControlsAndBehaviours.ModelforCustomControls;

namespace XForms.CustomControlsAndBehaviours.ViewModelforCustomControls
{

    public class RegisterUserViewModel : INotifyPropertyChanged
    {
        public RegisterModel User { get; set; }
        public bool ErrorMessageVisiliby { get; set; }
        public ICommand OnValidationCommand { get; set; }
        public RegisterUserViewModel()
        {
            User = new RegisterModel();

            OnValidationCommand = new Command((obj) =>
            {
                User.FirstName.NotValidMessageError = "Name is required";
                User.FirstName.IsNotValid = string.IsNullOrEmpty(User.FirstName.Name);

                User.Email.NotValidMessageError = "Email is required";
                User.Email.IsNotValid = string.IsNullOrEmpty(User.Email.Name);


                if (string.IsNullOrEmpty(User.Password.Name))
                {
                    User.Password.NotValidMessageError = "Password is required";
                    User.Password.IsNotValid = true;
                }
                else if (User.Password.Name.Length < 5)
                {
                    User.Password.NotValidMessageError = "Password must have more than 5 charcteres";
                    User.Password.IsNotValid = true;
                }
                else
                {
                    User.Password.IsNotValid = false;
                }

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

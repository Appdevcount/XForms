using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XForms.Models.XModel;

namespace XForms.ViewModels.XViewModels
{
    public class PersonViewModelTwoWay : INotifyPropertyChanged //INotifyPropertyChangedneeds to be implemented in View model to do 2 way binding with Model using its PropertyChangedEventHandler event
    {

        public Person _Person;

        // Property of type EntityModel
        public Person Person
        {
            get
            {
                return _Person;
            }
            set
            {
                _Person = value;
                OnPropertyChanged();
            }
        }

        public PersonViewModelTwoWay()
        {
            //EntityModel property is assigned a value in View Model
            Person = new Person
            {
                FName = "FirstName",
                LName = "LastName"
            };
        }

        private string _message;

        //Binded Confirmation message using custom Command in Xamarin.Forms controls
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        //Custom Command on Xamarin.Forms controls
        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
             {
                 Message = "Your Name " + Person.FName + " , " + Person.LName + " was successfully changed";
             });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;//Implementation of interface

        //This method needs to be manually typed for event tracking but no need to analyze
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

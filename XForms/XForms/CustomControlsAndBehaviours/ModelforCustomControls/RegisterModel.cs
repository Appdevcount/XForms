using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XForms.CustomControlsAndBehaviours.ModelforCustomControls
{
    //The RegisterModel is really simple, each property instead of being a simple string field will be a Field 
    //which will have three new properties to handle errors(Name- IsNotValid  – NotValidMessageError) .
    public class RegisterModel : INotifyPropertyChanged
    {
        public Field FirstName { get; set; } = new Field();
        public Field Email { get; set; } = new Field();
        public Field Password { get; set; } = new Field();

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Field : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public bool IsNotValid { get; set; }
        public string NotValidMessageError { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

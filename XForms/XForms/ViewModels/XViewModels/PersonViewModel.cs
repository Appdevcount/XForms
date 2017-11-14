using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XForms.Models.XModel;

namespace XForms.ViewModels.XViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }// Property of type EntityModel
        public PersonViewModel()
        {
            //EntityModel property is assigned a value in View Model
            Person = new Person 
            {
                FName = "FirstName",
                LName = "LastName"
            };
        }
        
    }
}

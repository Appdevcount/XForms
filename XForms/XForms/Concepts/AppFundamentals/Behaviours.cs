using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms.Concepts.AppFundamentals
{
    class Behaviours
    {
    }
    //Xamarin.Forms Behavior
    //=====================
    //        Creating a Xamarin.Forms Behavior
    //The sample application demonstrates a NumericValidationBehavior, which highlights the value entered by the user into an Entry control in red, 
    //            if it's not a double. The behavior is shown in the following code example:
    public class NumericValidationBehavior : Xamarin.Forms.Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
    //The NumericValidationBehavior derives from the Behavior<T> class, where T is an Entry.
    //The OnAttachedTo method registers an event handler for the TextChanged event, 
    //    with the OnDetachingFrom method de-registering the TextChanged event to prevent memory leaks.
    //    The core functionality of the behavior is provided by the OnEntryTextChanged method, which parses the value entered by the user into the Entry,
    //    and sets the TextColor property to red if the value isn't a double.

    //    Consuming a Xamarin.Forms Behavior
    //Every Xamarin.Forms control has a Behaviors collection, to which one or more behaviors can be added, as demonstrated in the following XAML code example:

    //<Entry Placeholder = "Enter a System.Double" >
    //    < Entry.Behaviors >
    //        < local:NumericValidationBehavior />
    //    </Entry.Behaviors>
    //</Entry>

}

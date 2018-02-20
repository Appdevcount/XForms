using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XForms.CustomControlsAndBehavior;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(XForms.Droid.CustomControlRenderers.CustomEntryRenderer))]
namespace XForms.Droid.CustomControlRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        //Added below constructor(optional) just to avoid warning -EntryRenderer.EntryRenderer()' is obsolete: 'This constructor is obsolete as of version 2.5. Please use EntryRenderer(Context) instead - https://www.davidbritch.com/2017/11/xamarinforms-25-and-local-context-in.html
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);



            //if (e.NewElement != null)
            //{
            //    var view = (CustomEntry)Element;

            //    if (view.IsCurvedCornersEnabled)
            //    {
            //        // creating gradient drawable for the curved background
            //        var _gradientBackground = new GradientDrawable();
            //        _gradientBackground.SetShape(ShapeType.Rectangle);
            //        _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());

            //        // Thickness of the stroke line
            //        _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

            //        // Radius for the curves
            //        _gradientBackground.SetCornerRadius(
            //            DpToPixels(this.Context,
            //                Convert.ToSingle(view.CornerRadius)));

            //        // set the background of the label
            //        Control.SetBackground(_gradientBackground);
            //    }

            //    // Set padding for the internal text from border
            //    Control.SetPadding(
            //        (int)DpToPixels(this.Context, Convert.ToSingle(12)),
            //        Control.PaddingTop,
            //        (int)DpToPixels(this.Context, Convert.ToSingle(12)),
            //        Control.PaddingBottom);
            //}


            //if (e.OldElement == null)
            //{
            //    //Control.SetBackgroundResource(Resource.Layout.rounded_shape);
            //    var gradientDrawable = new GradientDrawable();
            //    gradientDrawable.SetCornerRadius(60f);
            //    gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
            //    gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
            //    Control.SetBackground(gradientDrawable);

            //    Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            //}


            //From Hoessam Dellai
            if (e.OldElement == null)
            {
                //For Borderless entry(No botton border)
                //Control.Background = null;
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.LightBlue);
                gradientDrawable.SetColor(Android.Graphics.Color.LightGray);

                Control.SetBackground(gradientDrawable);
            }
        }
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}
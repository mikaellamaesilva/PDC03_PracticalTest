using PDC03_PracTest;
using Android.Content;
using Android.Graphics;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PasswordRenderer.Android;
using Android.Graphics.Drawables;
 

[assembly: ExportRenderer(typeof(PassEntry) , typeof(PasswordEntryRenderer))]

namespace PasswordRenderer.Android
{
 public class PasswordEntryRenderer :EntryRenderer
          

    {


        public PasswordEntryRenderer(Context context) : base (context)
        {



        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {


            }



            GradientDrawable gradientDrawable = new GradientDrawable();
            gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
            Control.SetBackground(gradientDrawable);
            this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
         Control.SetHintTextColor(global::Android.Graphics.Color.White);
        }


    }
}

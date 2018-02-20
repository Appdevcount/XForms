using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.API;

namespace XForms.Views.APIView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReqRes : ContentPage
    {
        public ReqRes()
        {
            InitializeComponent();


        }
        DataAccess da = new DataAccess();
        string Res;

        private void Get_Clicked(object sender, EventArgs e)
        {
            Res = da.find(1);
            //Res =Res.Replace('"', ' ').Substring(0, Res.Length-1);
            ResponseLabel.Text = (Res == "" | Res == null) ? "No Data Get" : Res;
        }

        private void GetAll_Clicked(object sender, EventArgs e)
        {
            Res = da.findAll();
            //Res = Res.Replace('"', ' ').Substring(0, Res.Length - 1);
            ResponseLabel.Text =( Res==""| Res ==null)? "No Data GetAll":Res;
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Res = da.Create().ToString();
            ResponseLabel.Text = Res;
        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            Res = da.Edit().ToString();
            ResponseLabel.Text = Res;
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            ResponseLabel.Text = "No Action configured";
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            Res = da.Delete(2).ToString();
            ResponseLabel.Text = Res;
        }
    }
}
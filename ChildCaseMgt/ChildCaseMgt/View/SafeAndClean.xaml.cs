using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using ChildCaseMgt.Model;
using System.IO;
using Xamarin.Essentials;

namespace ChildCaseMgt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SafeAndClean : ContentPage
    {

        public SafeAndClean()
        {
            InitializeComponent();
        }
        
        string Area0;
        string Water_Avaiability1;
        string Water_Accessibility1;
        string Water_Quality1;
        string WF0;
        string SelectedValue;

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db");
            SelectedValue = Province.Items[Province.SelectedIndex].ToString();


            if (Area1.IsChecked)
            {
                Area0 = Area1.Value.ToString();

            }
            else if (Area2.IsChecked)
            {
                Area0 = Area2.Value.ToString();
            }
            if (WAvail1.IsChecked)
            {
                Water_Avaiability1 = WAvail1.Value.ToString();

            }
            else if (Area2.IsChecked)
            {
                Water_Avaiability1 = WAvail2.Value.ToString();
            }
            if (WAccess1.IsChecked)
            {
                Water_Accessibility1 = WAccess1.Value.ToString();

            }
            else if (WAccess2.IsChecked)
            {
                Water_Accessibility1 = WAccess2.Value.ToString();
            }
            if (WQ1.IsChecked)
            {
                Water_Quality1 = WQ1.Value.ToString();

            }
            else if (WQ2.IsChecked)
            {
                Water_Quality1 = WQ2.Value.ToString();
            }
            if (WF1.IsChecked)
            {
                WF0 = WF1.Value.ToString();

            }
            else if (WF2.IsChecked)
            {
                WF0 = WF2.Value.ToString();
            }

            SafeAndCleanData data = new SafeAndCleanData()
            {
                Name = NameSC.Text,
                Age = AgeSC.Text,
                Province = SelectedValue,
                Area = Area0,
                Water_Avaiability=Water_Avaiability1,
                Water_Accessibility=Water_Accessibility1,
                Water_Quality=Water_Quality1,
                Wash_Facility= WF0
            };
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<SafeAndCleanData>();
                int rowInserted = conn.Insert(data);
                DisplayAlert("Success Message", "Data Successfully Saved", "Cancel");
            }



        }
    }
}
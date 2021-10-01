using ChildCaseMgt.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildCaseMgt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrossCutting : ContentPage
    {
        string Gender0;
        public CrossCutting()
        {
            InitializeComponent();
        }
        private void saveButton_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db");
            if (Gender1.IsChecked)
            {
                Gender0 = Gender1.Value.ToString();
            }
            else if (Gender2.IsChecked)
            {
                Gender0 = Gender2.Value.ToString();
            }
            CrossCuttingData data = new CrossCuttingData()
            {
                Name = ChildNameCC.Text,
                Age = int.Parse(ChildAgeCC.Text),
                Gender = Gender0

            };
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<CrossCuttingData>();
                int rowInserted = conn.Insert(data);
                DisplayAlert("Success Message", "Data Successfully Saved", "Cancel");
               
            }
        }
    }
}
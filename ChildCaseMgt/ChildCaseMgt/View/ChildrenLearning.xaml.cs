using ChildCaseMgt.Model;
using Microcharts;
using SkiaSharp;
using SQLite;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildCaseMgt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildrenLearning : ContentPage
    {


        public ChildrenLearning()
        {
            InitializeComponent();
        }
        string value;
        string education;
        string selectedValue;
        string enroll;

       
        public void saveButton_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db");

            if (GenderCL1.IsChecked)
            {
                value = GenderCL1.Value.ToString();
            }
            else if (GenderCL2.IsChecked)
            {
                value = GenderCL2.Value.ToString();
            }

            if (EducationCL1.IsChecked)
            {
                education = EducationCL1.Value.ToString();
            }
            else if (EducationCL2.IsChecked)
            {
                education = EducationCL2.Value.ToString();

            }
            selectedValue = Province.Items[Province.SelectedIndex].ToString();

            if (EnrollCL1.IsChecked)
            {
                enroll = EnrollCL1.Value.ToString();

            }
            else if (EnrollCL2.IsChecked)
            {
                enroll = EnrollCL2.Value.ToString();
            }

            CLData data = new CLData()
            {
                Name = NameCL.Text,
                Age = int.Parse(AgeCL.Text),
                Gender = value,
                Education = education,
                Province = selectedValue,
                Enrolled = enroll
            };
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<CLData>();
                int rowInserted = conn.Insert(data);
                DisplayAlert("Success Message", "Data Successfully Saved", "Cancel");
            }
        }
        
    }
}
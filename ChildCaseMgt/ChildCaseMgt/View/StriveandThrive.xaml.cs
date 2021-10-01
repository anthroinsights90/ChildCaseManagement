using ChildCaseMgt.Model;
using ChildCaseMgt.ViewModels;
using Microcharts;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using SkiaSharp;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Icu.Text.Transliterator;

namespace ChildCaseMgt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StriveandThrive : ContentPage
    {
        public StriveandThrive(string name, string details, string image)
        {
            InitializeComponent();
           
            chartViewBar1.Chart = new BarChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
            chartViewBar2.Chart = new BarChart { Entries = entries1, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
            chartViewBar3.Chart = new BarChart { Entries = entries2, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
            
        }
        string HepatitisValue;
        string PolioValue;
        
        private ChartEntry[] entries = new ChartEntry[]
       {
            new ChartEntry(19)
            {
                Label="15",
                ValueLabel="0.8",
                Color = SKColor.Parse("#7e5429")

            },
            new ChartEntry(18)
            {
                Label = "16",
                ValueLabel = "3",
                Color = SKColor.Parse("#7e5429")
            },

            new ChartEntry(17)
            {
                Label = "17",
                ValueLabel = "5.4",
                Color = SKColor.Parse("#7e5429")
            },
            new ChartEntry(16)
            {
                Label = "18",
                ValueLabel = "13.1",
                Color = SKColor.Parse("#7e5429")
            },
            new ChartEntry(15)
            {
                Label = "19",
                ValueLabel = "19.4",
                Color = SKColor.Parse("#7e5429")
            }
           
       };

        private readonly ChartEntry[] entries1 = new ChartEntry[]
   {
            new ChartEntry(4)
            {
                Label="Highest",
                ValueLabel="4.8",
                Color = SKColor.Parse("#9abcde")

            },
            new ChartEntry(7)
            {
                Label="Fourth",
                ValueLabel="7.7",
                Color = SKColor.Parse("#9abcde")

            },
            new ChartEntry(8)
            {
                Label = "Middle",
                ValueLabel = "8.8",
                Color = SKColor.Parse("#9abcde")
            },
            new ChartEntry(9)
            {
                Label = "Second",
                ValueLabel = "9.8",
                Color = SKColor.Parse("#9abcde")
            },
            new ChartEntry(10)
            {
                Label = "Lowest",
                ValueLabel = "10",
                Color = SKColor.Parse("#9abcde")
            }
   };
        private readonly ChartEntry[] entries2 = new ChartEntry[]
            {
            new ChartEntry(15)
            {
                Label="No Education",
                ValueLabel="15.1",
                Color = SKColor.Parse("#415b2b")

            },
            new ChartEntry(9)
            {
                Label = "Primary",
                ValueLabel = "9.4",
                Color = SKColor.Parse("#415b2b")
            },
            new ChartEntry(6)
            {
                Label = "Middle",
                ValueLabel = "5.9",
                Color = SKColor.Parse("#415b2b")
            },
            new ChartEntry(4)
            {
                Label = "Secondary",
                ValueLabel = "4.1",
                Color = SKColor.Parse("#415b2b")
            },
            new ChartEntry(1)
            {
                Label = "Higher",
                ValueLabel = "1.3",
                Color = SKColor.Parse("#415b2b")
            }
   };
        private void saveButton_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db");
            if (Hepatits1.IsChecked)
            {
                HepatitisValue = Hepatits1.Value.ToString();
            }
            else if (Hepatits2.IsChecked)
            {
                HepatitisValue = Hepatits2.Value.ToString();
            }
            if (Polio1.IsChecked)
            {
                PolioValue = Polio1.Value.ToString();
            }
            else if (Polio2.IsChecked)
            {
                PolioValue = Polio2.Value.ToString();
            }

            StriveAndThriveData data = new StriveAndThriveData()
            {
                Name = ChildName.Text,
                Age = ChildAge.Text,
                Height = ChildHeight.Text,
                Weight = ChildWeight.Text,
                Iron_Prop = IronProp.Text,
                VitaminA = AVit.Text,
                Aneamia_Prop = AneamiaProp.Text,
                Zinc = ZincProp.Text,
                Polio = PolioValue,
                Hepatitis = HepatitisValue
            };
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<StriveAndThriveData>();
                int rowInserted = conn.Insert(data);
                DisplayAlert("Success Message", "Data Successfully Saved", "Cancel");
            }
        }
        public async void statsButton_Clicked(Object sender, EventArgs e)
        {


            await Navigation.PushAsync(new Plot());
        }

    }
} 
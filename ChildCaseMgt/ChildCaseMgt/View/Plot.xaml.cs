using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildCaseMgt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plot : ContentPage
    {
        public Plot()
        {
            
            ViewPlot();
        }
        private PlotView _opv = new PlotView();
        public void ViewPlot()
        {
            var plotModel = new PlotModel { Title = "Birth Registration across Provinces and Regions" };
            CategoryAxis xaxis = new CategoryAxis();
            xaxis.Position = AxisPosition.Bottom;
            xaxis.MajorGridlineStyle = LineStyle.Solid;
            xaxis.MinorGridlineStyle = LineStyle.Dot;
            xaxis.Labels.Add("Punjab");
            xaxis.Labels.Add("Sindh");
            xaxis.Labels.Add("Balochistan");
            xaxis.Labels.Add("KP");

            ColumnSeries s1 = new ColumnSeries();
            s1.IsStacked = false;
            s1.Items.Add(new ColumnItem(68));
            s1.Items.Add(new ColumnItem(18));
            s1.Items.Add(new ColumnItem(25));
            s1.Items.Add(new ColumnItem(21));


            ColumnSeries s2 = new ColumnSeries();
            s2.IsStacked = false;
            s2.Items.Add(new ColumnItem(82));
            s2.Items.Add(new ColumnItem(15));
            s2.Items.Add(new ColumnItem(23));
            s2.Items.Add(new ColumnItem(43));


            ColumnSeries s3 = new ColumnSeries();
            s3.IsStacked = false;
            s3.Items.Add(new ColumnItem(63));
            s3.Items.Add(new ColumnItem(18));
            s3.Items.Add(new ColumnItem(26));
            s3.Items.Add(new ColumnItem(41));

            plotModel.Series.Add(s1);
            plotModel.Series.Add(s2);
            plotModel.Series.Add(s3);

            plotModel.Axes.Add(xaxis);
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 100 });

            _opv.Model = plotModel;
            Content = _opv;
        }
    }

}
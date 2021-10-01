using ChildCaseMgt.Model;
using ChildCaseMgt.ViewModels;
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
    public partial class FirstScreen : ContentPage
    {
        
        public FirstScreen()
        {
           
            InitializeComponent();
            BindingContext = new MyListData();

            
        }
        public async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyListModel;
            if (mydetails.id == 1)
            {
                await Navigation.PushAsync(new StriveandThrive(mydetails.Name, mydetails.Details, mydetails.Images));
            }
            if (mydetails.id == 2)
            {
                await Navigation.PushAsync(new ChildrenLearning());
            }
            if (mydetails.id == 3)
            {
                await Navigation.PushAsync(new Exploitation());
            }
            if (mydetails.id == 4)
            {
                await Navigation.PushAsync(new SafeAndClean());
            }
            if (mydetails.id == 5)
            {
                await Navigation.PushAsync(new CrossCutting());
            }
        }
    }
}
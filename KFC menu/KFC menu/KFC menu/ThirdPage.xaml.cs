using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFC_menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
            List<DrniksInfo> lastList = new List<DrniksInfo>
            {
                new DrniksInfo{Id = 1, Name = "Mountain Dew", Price="Price: 3.99$", ImageUrl="mntdew.jpg", Info="Tap For Details"},
                new DrniksInfo{Id = 2, Name = "Fanta", Price="Price: 3.44$", ImageUrl="fanta.png", Info="Tap For Details"},
               new DrniksInfo{Name = "CocaCola", Price="Price: 2.44$", ImageUrl="cola.png"},
                new DrniksInfo{Name = "Pepsi", Price="Price: 2.99$", ImageUrl="pepsi.jpg"},
                 new DrniksInfo{Name = "Water", Price="Price: 1$", ImageUrl="water.jpg"},
            };
            myListView.ItemsSource = lastList;
        }

       async private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as DrniksInfo;
            switch (myselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new Drinks1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Drinks2());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
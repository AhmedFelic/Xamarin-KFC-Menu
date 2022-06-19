using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFC_menu.DataModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFC_menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
            List<DesertInfo> myList = new List<DesertInfo>
            {
               new DesertInfo{Id = 1,  Name = "Milky Bar Cream", Price="Price: 5.34$", ImageUrl="cream.jpg", Info="Tap For Details"},
               new DesertInfo{Name = "Sundae Chocolate", Price="Price: 5.44$", ImageUrl="berrySundae.jpg"},
               new DesertInfo{Id = 2, Name = "Hersheis Pie", Price="Price: 6.99$", ImageUrl="pie.jpg", Info="Tap For Details"},
               new DesertInfo{Name = "Chocolate Chips", Price="Price: 4.99$", ImageUrl="chocolateChips.jpg"},
               new DesertInfo{Name = "Chocolate Chip", Price="Price: 1.99$", ImageUrl="chip.jpg"},
                 

            };
            myListView.ItemsSource = myList;


        }

       async private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as DesertInfo;
            switch (myselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new Dessert1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Dessert2());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
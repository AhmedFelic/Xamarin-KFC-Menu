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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            List<FoodInfo> newList = new List<FoodInfo>
            {
                 new FoodInfo{Id = 1, Name = "KFC Chicken Menu", Price="Price: 14.99$", ImageUrl="chickenMeni.jpg", Info="Tap For Details"},
                new FoodInfo{Name = "KFC Chicken", Price="Price: 7.44$", ImageUrl="chicken.jpg"},
               new FoodInfo{Name = "Burger", Price="Price: 8.44$", ImageUrl="hamburger.jpg"},
               new FoodInfo{Id = 2, Name = "Vegan Burger", Price="Price: 9.99$", ImageUrl="veganHam.jpg", Info="Tap For Details"},
                new FoodInfo{Name = "Fries", Price="Price: 2.99$", ImageUrl="fries.jpg"},
                
            };
            myListView.ItemsSource = newList;
        }

        async private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as FoodInfo;
            switch (myselecteditem.Id)
            {
                case 1:
                    await Navigation.PushAsync(new Food1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Food2());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
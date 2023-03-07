using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkateboardApp.Models;
using SkateboardApp.Services;
using SkateboardApp.Views;
using System.Collections.ObjectModel;

namespace SkateboardApp.ViewModels
{
    public partial class CheckoutViewModel : ObservableObject
    {
        readonly BasketService _basketService;

        public CheckoutViewModel(BasketService basketService)
        {
            _basketService = basketService;

            LoadData();
        }

        public ObservableCollection<BasketItem> Basket { get; set; }

        [RelayCommand]
        async Task GoToDetails(BasketItem basketItem)
        {
            if (basketItem == null)
                return;

            await Shell.Current.GoToAsync(nameof(CustomizeView), true, new Dictionary<string, object>
            {
                {"BasketItem", basketItem }
            });
        }

        void LoadData()
        {
            var basket = _basketService.GetBasket();

            Basket = new ObservableCollection<BasketItem>(basket);
        }
    }
}
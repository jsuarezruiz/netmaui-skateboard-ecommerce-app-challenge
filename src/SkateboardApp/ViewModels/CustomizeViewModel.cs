using CommunityToolkit.Mvvm.ComponentModel;
using SkateboardApp.Models;
using SkateboardApp.Services;
using System.Collections.ObjectModel;

namespace SkateboardApp.ViewModels
{
    [QueryProperty(nameof(BasketItem), "BasketItem")]
    public partial class CustomizeViewModel : ObservableObject
    {
        readonly BasketService _basketService;

        public CustomizeViewModel(BasketService basketService)
        {
            _basketService = basketService;

            LoadData();
        }

        public ObservableCollection<BasketItem> Basket { get; set; }

        [ObservableProperty]
        BasketItem basketItem; 
        
        void LoadData()
        {
            var basket = _basketService.GetBasket();

            Basket = new ObservableCollection<BasketItem>(basket);
        }
    }
}
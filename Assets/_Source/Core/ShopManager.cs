using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField] private List<ProductionBuilding> _productionBuildings;
        [SerializeField] private ResourceBank _resourceBank;
        
        private void TryBuy(GameResource whatBuy, GameResource currency, int cost)
        {
            if (_resourceBank.GetResource(currency).Value < cost) return;
            _resourceBank.GetResource(currency).Value -= cost;
            _productionBuildings[(int)whatBuy].IncreaseProductionLevel();
        }

        public void HandleBuyClick(string input)
        {
            string[] elements = input.Split(' ');

           int.TryParse(elements[2], out int cost);
           int.TryParse(elements[1], out int currency);
           int.TryParse(elements[0], out int whatBuy);
           
           TryBuy((GameResource)whatBuy, (GameResource)currency, cost);
        } 
    }
}

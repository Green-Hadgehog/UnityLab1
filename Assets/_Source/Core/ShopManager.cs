using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField] private List<ProductionBuilding> _productionBuildings;
        [SerializeField] private ResourceBank _resourceBank;
        
        public void TryBuy(BuyLevel buyLevel)
        {
            if (_resourceBank.GetResource(buyLevel.Currency).Value < buyLevel.Cost) return;
            _resourceBank.GetResource(buyLevel.Currency).Value -= buyLevel.Cost;
            _productionBuildings[(int)buyLevel.WhatBuy].IncreaseProductionLevel();
        }
    }
}

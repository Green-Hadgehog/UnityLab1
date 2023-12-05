using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Core
{
    public class ProductionVisual : MonoBehaviour
    {
        [SerializeField] private List<TMP_Text> _productionLvlTexts;
        [SerializeField] private List<ProductionBuilding> _productionBuildings;
        [SerializeField] private string _prefix = "Lvl ";
        void Awake()
        {
            for (int i = 0; i < 5; i++)
            {
                int i1 = i;
                _productionBuildings[i].GetProductionLevel().OnValueChanged += (newValue =>
                    _productionLvlTexts[i1].text = (_prefix + newValue));
            }
        }
    }
}

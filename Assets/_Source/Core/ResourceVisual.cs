using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace _Source.Core
{
  public class ResourceVisual : MonoBehaviour
  {
    [SerializeField] private ResourceBank _resourceBank;
    [SerializeField] private List<TMP_Text> _resourceTexts;
    void Awake()
    {
      _resourceBank.GetResource(GameResource.Humans).OnValueChanged += (newValue =>
        _resourceTexts[(int)GameResource.Humans].text = newValue.ToString());
      
      _resourceBank.GetResource(GameResource.Food).OnValueChanged += (newValue =>
        _resourceTexts[(int)GameResource.Food].text = newValue.ToString());
      
      _resourceBank.GetResource(GameResource.Wood).OnValueChanged += (newValue =>
        _resourceTexts[(int)GameResource.Wood].text = newValue.ToString());
      
      _resourceBank.GetResource(GameResource.Gold).OnValueChanged += (newValue =>
        _resourceTexts[(int)GameResource.Gold].text = newValue.ToString());
      
      _resourceBank.GetResource(GameResource.Stone).OnValueChanged += (newValue =>
        _resourceTexts[(int)GameResource.Stone].text = newValue.ToString());
    }
  }
}
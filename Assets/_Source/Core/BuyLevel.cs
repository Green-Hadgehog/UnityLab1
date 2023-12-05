using UnityEngine;

namespace Core
{
  [CreateAssetMenu(fileName = "BuyLevelData", menuName = "BuyLevel", order = 1)]
  public class BuyLevel : ScriptableObject
  {
    [SerializeField] private GameResource _whatBuy;
    [SerializeField] private GameResource _currency;
    [SerializeField] private int _cost;

    public GameResource WhatBuy => _whatBuy;
    public GameResource Currency => _currency;
    public int Cost => _cost;
  }
}
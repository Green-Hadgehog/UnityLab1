using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
  public class ResourceBank : MonoBehaviour
  {
    private Dictionary<GameResource, ObservableInt> _bank = new()
    {
      { GameResource.Humans, new ObservableInt(0) }, { GameResource.Food, new ObservableInt(0) },
      { GameResource.Wood, new ObservableInt(0) }, { GameResource.Gold, new ObservableInt(0) },
      { GameResource.Stone, new ObservableInt(0) }
    };

    public void ChangeResource(GameResource r, int v)
      => _bank[r].Value += v;

    public ObservableInt GetResource(GameResource r)
      => _bank[r];
  }
}
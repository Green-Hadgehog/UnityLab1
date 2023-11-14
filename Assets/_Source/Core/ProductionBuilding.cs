using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Source.Core
{
  public class ProductionBuilding : MonoBehaviour
  {
    [SerializeField] private ResourceBank _resourceBank;
    [SerializeField] private int _increaseDelta = 1;
    [SerializeField] private GameResource _resource;
    [SerializeField] private float _productionTime = 1;

    public void IncreaseResource()
    {
      StartCoroutine(Increase());
    }

    private IEnumerator Increase()
    {
      yield return new WaitForSeconds(_productionTime);
      _resourceBank.ChangeResource(_resource, _increaseDelta);
    }

    public float GetProductionTime()
      => _productionTime;
  }
}
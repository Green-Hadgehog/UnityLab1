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

    private ObservableInt _productionLevel = new(1);

    public ObservableInt GetProductionLevel()
      => _productionLevel;

    public void IncreaseProductionLevel()
      => _productionLevel.Value++;

    public void IncreaseResource()
    {
      StartCoroutine(Increase());
    }

    public float CalculateProductionTime()
      => _productionTime - 0.4f * (_productionLevel.Value - 1);

    private IEnumerator Increase()
    {
      float newProductionTime = CalculateProductionTime();
      yield return new WaitForSeconds(newProductionTime);
      _resourceBank.ChangeResource(_resource, _increaseDelta);
    }
  }
}
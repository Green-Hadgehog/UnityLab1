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
        [SerializeField] private double _productionTime = 2;
        public void IncreaseResource()
        {
            StartCoroutine(Increase());
        }

        private IEnumerator Increase()
        {
            yield return new WaitForSeconds(2f);
            _resourceBank.ChangeResource(_resource, _increaseDelta);
        }
    }
}

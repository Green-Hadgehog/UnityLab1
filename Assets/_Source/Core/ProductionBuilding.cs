using UnityEngine;

namespace _Source.Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] private ResourceBank _resourceBank;
        [SerializeField] private int _increaseDelta = 1;
        [SerializeField] private GameResource _resource;
    
        public void IncreaseResource()
        {
            _resourceBank.ChangeResource(_resource, _increaseDelta);
        }
    }
}

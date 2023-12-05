using UnityEngine;

namespace Core
{
  public class GameManager : MonoBehaviour
  {
    [SerializeField] private ResourceBank _resourceBank;
    private const int START_HUMANS_VALUE = 10;
    private const int START_FOOD_VALUE = 5;
    private const int START_WOOD_VALUE = 5;

    void Start()
    {
      _resourceBank.ChangeResource(GameResource.Humans, START_HUMANS_VALUE);
      _resourceBank.ChangeResource(GameResource.Food, START_FOOD_VALUE);
      _resourceBank.ChangeResource(GameResource.Wood, START_WOOD_VALUE);
    }
  }
}
using _Source.Core;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;
using Button = UnityEngine.UI.Button;

namespace _Source.Presentation
{
  public class SliderAnimation : MonoBehaviour
  {
    private Slider _slider;
    private Button _button;
    [SerializeField] private int _countSteps;

    private float _sliderValueDelta;
    private float _stepCooldown;

    [SerializeField] private float _pauseTime;
    
    void Start()
    {
      _slider = gameObject.GetComponentInChildren<Slider>();
      _button = gameObject.GetComponentInChildren<Button>();
    }

    private void IncreaseSliderValue()
    {
      float newValue = _slider.value + _sliderValueDelta;
      if (newValue < 1)
      {
        _slider.value = newValue;
      }
      else
      {
        _slider.value = 1;
        _button.interactable = true;
        CancelInvoke();
      }
    }
    
    public void RunAnimation()
    {
      _button.interactable = false;
      _slider.value = 0;
      _sliderValueDelta = 1.0f / _countSteps;
      _stepCooldown = (gameObject.GetComponentInChildren<ProductionBuilding>().GetProductionTime() - _pauseTime) / _countSteps;
      InvokeRepeating(nameof(IncreaseSliderValue), _pauseTime, _stepCooldown);
    }

  }
}
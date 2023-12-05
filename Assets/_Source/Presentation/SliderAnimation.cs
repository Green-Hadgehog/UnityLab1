using Core;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;
using Button = UnityEngine.UI.Button;

namespace Presentation
{
  public class SliderAnimation : MonoBehaviour
  {
    private Slider _slider;
    private Button _button;
    [SerializeField] private int _countSteps;

    private float _sliderValueDelta;
    private float _stepCooldown;

    [SerializeField] private float _pauseTime;

    private const float MINIMAL_ANIMATION_TIME = 0.01f;

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
      float animationTime = gameObject.GetComponentInChildren<ProductionBuilding>().CalculateProductionTime() -
                            _pauseTime;

      if (animationTime <= 0)
      {
        _pauseTime = 0;
        animationTime = MINIMAL_ANIMATION_TIME;
      }

      _stepCooldown = animationTime / _countSteps;
      InvokeRepeating(nameof(IncreaseSliderValue), _pauseTime, _stepCooldown);
    }
  }
}
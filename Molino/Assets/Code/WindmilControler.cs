using UnityEngine;
using UnityEngine.UIElements; //UI Toolkit

public class WindmilControler : MonoBehaviour
{
    private Slider _windDirectionSlider;
    private Slider _windSpeedSlider;
        
    private Animator _animator;

    void OnEnable()
    {
        _animator = GetComponent<Animator>();
    
        var root = GetComponent<UIDocument>().rootVisualElement;
        _windDirectionSlider = root.Q<Slider>("WindDirectionSlider");
        _windSpeedSlider = root.Q<Slider>("WindSpeedSlider");

        _windDirectionSlider.RegisterValueChangedCallback(evt => 
        { 
            _animator.SetFloat("WindDirection", evt.newValue); 
        }
        );

        _windSpeedSlider.RegisterValueChangedCallback(evt => 
        {
            _animator.SetFloat("WindSpeed", evt.newValue);
        }
        );
    
    
    }


}

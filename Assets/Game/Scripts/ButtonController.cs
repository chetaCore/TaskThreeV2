using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private float _inputValue = 0;
    public float InputValue => _inputValue;

    public void OnPointerDown(PointerEventData eventData)
    {
        _inputValue = 1f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _inputValue = 0f;
    }

}
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisuals : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;

    [SerializeField] private RectTransform _knob;
    [SerializeField] private Vector2 _onPosition;
    [SerializeField] private Vector2 _offPosition;

    [SerializeField] private Image _background;
    [SerializeField] private Color _onColor;
    [SerializeField] private Color _offColor = Color.grey;

    void Start()
    {
        _toggle.OnClick += Click;
    }

    private void Click(bool isOn)
    {
        if (isOn)
        {
            _background.color = _onColor;
            _knob.anchoredPosition = _onPosition;
        }
        else
        {
            _background.color = _offColor;
            _knob.anchoredPosition = _offPosition;
        }
    }
}
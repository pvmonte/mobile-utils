using DG.Tweening;
using UnityEngine;

public class CanvasAnimations : MonoBehaviour
{
    [SerializeField] private RectTransform _painel;
    
    void Start()
    {
        _painel.localScale = Vector3.zero;
        Grow();
    }
    
    public void Grow()
    {
        _painel.DOScale(Vector3.one, 0.25f);
    }
    
    public Tweener Shrink()
    {
        return _painel.DOScale(Vector3.zero, 0.25f);
    }
}

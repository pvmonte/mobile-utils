using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    [SerializeField] private CanvasAnimations _canvas;
    private Button _btn;
    
    void Start()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(Click);
    }

    private void Click()
    {
        var tweener = _canvas.Shrink();
        tweener.onComplete += Tweener_OnComplete;
    }

    private void Tweener_OnComplete()
    {
        SceneManager.UnloadSceneAsync("Settings");
    }
}

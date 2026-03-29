using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private Button _btn;
    
    void Start()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(Click);
    }

    private void Click()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
    }
}

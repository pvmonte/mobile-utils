using UnityEngine;

public class VibrationController : MonoBehaviour
{
    public static VibrationController instance;
    private bool _isVibrationEnabled;
    
    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }
    
    public void Vibrate()
    {
        if (!_isVibrationEnabled) return;
        
        Handheld.Vibrate();
    }
    
    public void SetVibrationEnabled(bool enabled)
    {
        _isVibrationEnabled = enabled;
    }
}

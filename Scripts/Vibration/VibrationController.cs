using UnityEngine;

public class VibrationController : MonoBehaviour
{
    public static VibrationController Instance { get; private set; }
    private bool _isVibrationEnabled;
    
    private void Awake()
    {
        if (Instance is null)
        {
            Instance = this;
        }
        else if(Instance != this)
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

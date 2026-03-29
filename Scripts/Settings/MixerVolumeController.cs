using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

public class MixerVolumeController : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _parameterName = "SfxVolume";
    private Toggle _toggle;
    
    void Start()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.OnClick += Toggle_OnClick;
    }

    private void Toggle_OnClick(bool value)
    {
        _audioMixer.SetFloat(_parameterName, value ? 0 : -80);
    }
}

using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EconomyEventListener : MonoBehaviour
{
    private IEconomyEventSender _eventSender;
    
    void Start()
    {
        _eventSender = GetComponent<IEconomyEventSender>();
        _eventSender.OnCoinsEarned += EarnCoins;
    }
    
    private void EarnCoins(int amount)
    {
        EconomyController.Instance.AddCoins(amount);
    }
}
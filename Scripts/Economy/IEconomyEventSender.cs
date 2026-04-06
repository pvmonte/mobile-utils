using System;

public interface IEconomyEventSender
{
    public event Action<int> OnCoinsEarned; 
}
using System;
using UnityEngine;

public class MoneyManager : IMoneyManager
{
    public int Money { get; private set; }

    public MoneyManager(int startMoney)
    {
        Money = Mathf.Max(0, startMoney);
    }

    public void AddMoney(int amount)
    {
        if (amount <= 0)
            return;

        Money += amount;
    }

    public bool SpendMoney(int amount)
    {
        if (amount <= 0 || Money < amount)
            return false;

        Money -= amount;
        return true;
    }
}
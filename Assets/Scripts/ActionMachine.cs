using UnityEngine;

public interface ActionMachine 
{
    void givemoney();


}
public interface ISpeedBoostable
{
    bool IsBoosted { get; }
    void ApplySpeedBoost(float multiplier, float duration);
}
public interface IMoneyManager
{
    int Money { get; }

    void AddMoney(int amount);
    bool SpendMoney(int amount);
}





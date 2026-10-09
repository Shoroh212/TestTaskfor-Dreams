using UnityEngine;
using VContainer;

public class Machine : MonoBehaviour, ActionMachine
{
    [SerializeField] private MachineData _machineData;

    [SerializeField] private int _moneyPerCraft = 10;

    private int _level;
    private bool _locked;
    private float _speedWork;
    private float _price;
    private float _updatePrice;

    private IMoneyManager _moneyManager;
    private float _timer;

    [Inject]
    public void Construct(IMoneyManager moneyManager)
    {
        _moneyManager = moneyManager;
    }

    private void Awake()
    {
        _machineData.Level = _level;
        _machineData.Locked = _locked;
        _machineData.SpeedWork = _speedWork;
        _machineData.Price = _price;
        _machineData.UpdatePrice = _updatePrice;
    }

    private void Update()
    {
        if (_moneyManager == null || _speedWork <= 0f)
            return;

        _timer += Time.deltaTime;

        while (_timer >= _speedWork)
        {
            _timer -= _speedWork;
            givemoney();
        }
    }

    public void givemoney()
    {
        _moneyManager.AddMoney(_moneyPerCraft);
        Debug.Log($"Machine crafted {_moneyPerCraft} money. Total money: {_moneyManager.Money}");
    }
}
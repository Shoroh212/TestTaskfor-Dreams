using System;
using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] private MachineData _machineData;

    private int _level;
    private bool _locked;
    private float _speedWork;
    private float _price;
    private float _updatePrice;

    void Awake()
    {
        _machineData.Level = _level;
        _machineData.Locked = _locked;
        _machineData.SpeedWork = _speedWork;
        _machineData.Price = _price;
        _machineData.UpdatePrice = _updatePrice;
    }
    void Start()
    {
        Debug.Log("Machine started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void craftMoney()
    {
        
    }



}



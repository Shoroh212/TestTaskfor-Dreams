using UnityEngine;

[CreateAssetMenu(fileName = "MachineData", menuName = "ScriptableObjects/MachineData", order = 1)]
public class MachineData : ScriptableObject
{
    public bool Locked; 
    public int Level;
    public float SpeedWork;
    public float Price;
    public float UpdatePrice;

}

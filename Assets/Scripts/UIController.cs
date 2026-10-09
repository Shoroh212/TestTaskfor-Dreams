using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    MoneyManager _moneyManager;
    [SerializeField]private TextMeshProUGUI _moneyText;

    void Start()
    {
      _moneyText.text  = _moneyManager.Money.ToString();

    }
}

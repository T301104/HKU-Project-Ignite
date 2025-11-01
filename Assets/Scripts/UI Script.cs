using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public PlayerDamage playerDamage;
    public MonkeyManager monkeyManager;
    public TextMeshProUGUI MonkeyCount;
    public TextMeshProUGUI PlayerHP;

    public void Start()
    {
        UpdateText();
    }


    public void Update()
    {
        UpdateText();
    }


    public void UpdateText() 
    {
        PlayerHP.text = playerDamage.Health.ToString();
        MonkeyCount.text = monkeyManager.usableMonkeys.ToString();
    }

}

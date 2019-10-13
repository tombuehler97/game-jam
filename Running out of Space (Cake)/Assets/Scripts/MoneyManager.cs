using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static float money;
    private PlayerEconomy playerEconomy;

    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        playerEconomy = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEconomy>();
        text = GetComponent<Text>();
        money = playerEconomy.currentMoney;
    }

    // Update is called once per frame
    void Update()
    {
        money = playerEconomy.currentMoney;
        text.text = "" + money.ToString("F2");
    }
}

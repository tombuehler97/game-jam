using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeManager : MonoBehaviour
{
    public static int cakes;
    private PlayerEconomy playerEconomy;

    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        playerEconomy = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEconomy>();
        text = GetComponent<Text>();

        cakes = playerEconomy.currentCakes;
    }

    // Update is called once per frame
    void Update()
    {
        cakes = playerEconomy.currentCakes;
        text.text = "" + cakes;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEconomy : MonoBehaviour
{
    // Start is called before the first frame update
    public float startingMoney = 420.69f;
    public float currentMoney;
    public int currentCakes;
    public bool broke;
    public float cakePrize = 10f;

    private Animator anim;
    private PlayerMovement playerMovement;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        currentMoney = startingMoney;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReceiveMoney(float sum)
    {
        currentMoney += sum;
    }

    public void LoseMoney(float sum)
    {
        currentMoney -= sum;

        if (currentMoney < 0f)
        {
            broke = true;
        }
    }

    public void BuyCake()
    {
        int count = (int)(currentMoney / cakePrize);
        float rest = currentMoney % cakePrize;

        currentCakes += count;
        currentMoney = rest;
    }
}

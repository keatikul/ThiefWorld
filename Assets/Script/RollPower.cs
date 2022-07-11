using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPower : MonoBehaviour
{
    public DiceScript diceSc;
    public float holddownStarttime;
    bool buttonHoldDown = false;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonHoldDown == true)
        {
            holddownStarttime += Time.deltaTime;
        }
        if(holddownStarttime <= 2)
        {
            power = 500;
        }else
        {
            power = 30;
        }

        if(buttonHoldDown == false)
        {
            holddownStarttime = 0;
        }
    }

    public void HoldButton()
    {
        buttonHoldDown = true;
    }

    public void ReleaseButton()
    {
        buttonHoldDown = false;
        diceSc.Roll();
        //isRoll = true;
    }
}

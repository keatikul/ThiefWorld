using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public Image imagePowerUp;
    public bool isPowerUp = false;
    private bool isDirectionUp = true;
    public float amtPower = 0.0f;
    private float powerSpeed = 100.0f;
    public int dicepoint;
    public static PowerUp instancePowerUp;
    public bool isRoll = false;
    //public bool moveBoat = false;
    public GameObject dice;

    void Awake()
    {
        MakeSingleton();
    }
    void Update()
    {
        if (isPowerUp)
        {
            PowerActive();
            dicepoint = 0;
        }
        if (dicepoint <= 0 && amtPower == 0.0f && isPowerUp == false)
        {
            dicepoint = 0;
            isRoll = false;
            //StopRoll();
            //isRoll = false;
        }
        
        //Debug.Log("Amtpower" + amtPower);
        //DiceRoll();
    }
    void StopRoll()
    {
        dice.SetActive(false);
        dicepoint = 0;
        
    }

    void MakeSingleton()
    {
        if (instancePowerUp == null)
        {
            instancePowerUp = this;
        }
    }

    void DiceRoll()
    {
        if (amtPower >= 50f)
        {
            //dicepoint = Random.Range(3, 7);
            dicepoint = 39;
            //isRoll = true;
            Debug.Log("Dice" + dicepoint);
            ClearValue();
        }
        else
        {
            dicepoint = Random.Range(1, 4);
            //isRoll = true;
            Debug.Log("Dice" + dicepoint);
            ClearValue();
        }
    }
    void ClearValue()
    {
        amtPower = 0.0f;
        imagePowerUp.fillAmount = 0;
    }

    void PowerActive()
    {
        if (isDirectionUp)
        {
            amtPower += Time.deltaTime * powerSpeed;
            if (amtPower > 100)
            {
                isDirectionUp = false;
                amtPower = 100.0f;
            }
        }
        else
        {
            amtPower -= Time.deltaTime * powerSpeed;
            if (amtPower < 0)
            {
                isDirectionUp = true;
                amtPower = 0.0f;
            }
        }
        imagePowerUp.fillAmount = (1f - 0f) * amtPower / 100.0f + 0f;
    }
    public void StartPowerUp()
    {
        isPowerUp = true;
        amtPower = 0.0f;
        isDirectionUp = true;
    }
    public void EndPowerUp()
    {   
        DiceRoll();
        isPowerUp = false;
        isRoll = true;
    }
}

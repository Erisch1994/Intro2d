using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public int coins;

    public GameObject doorTwo;


    void Start()
    {
        doorTwo = GameObject.Find("DoorTwo");
    }


    void Update()
    {
        scoreText.text = coins.ToString();
        
        if (coins >= 14 && doorTwo != null)
        {
            Destroy(doorTwo);
        }

    }

    public void AddCoins()
    {
        coins++;
    }

}

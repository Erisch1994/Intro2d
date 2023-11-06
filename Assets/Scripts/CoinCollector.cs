using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private TextManager textManager;

    void Start()
    {
        textManager = FindObjectOfType<TextManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textManager.AddCoins();

        }
    }
}
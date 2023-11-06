using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioClip audioPlaay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(audioPlaay);
        Destroy(gameObject);
    }
}
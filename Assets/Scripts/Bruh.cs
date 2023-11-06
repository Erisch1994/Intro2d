using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruh : MonoBehaviour
{
    public GameObject Princess;
    public AudioClip audioPlaay;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(audioPlaay);
        Destroy(Princess);


    }
}


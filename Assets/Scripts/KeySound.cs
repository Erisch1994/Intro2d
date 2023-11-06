using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeySound : MonoBehaviour
{
    public GameObject door;
    public AudioClip audioPlay;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        collision.gameObject.GetComponent<AudioSource>().PlayOneShot(audioPlay);
        Destroy(door);

       
    }
}

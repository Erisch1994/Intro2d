using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessWin : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Princess")
        {
            Destroy(collision.gameObject);
        }
    }
}    
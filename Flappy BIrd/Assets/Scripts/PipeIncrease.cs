using System.Collections;
using System.Collections.Generic;  
using UnityEngine;

public class PipeIncrease : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogWarning("collision detected");
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
        }
    }


}

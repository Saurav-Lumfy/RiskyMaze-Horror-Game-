using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blurlingerAi : MonoBehaviour
{
    public GameObject blurlinger, block1, block2, block3;
    public Collider collision;
    public bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blurlinger.SetActive(true);
            if(blocks == true)
            {
                block1.SetActive(true);
                block2.SetActive(false);
                block3.SetActive(false);
            }
            collision.enabled = false;
        }
    }
}
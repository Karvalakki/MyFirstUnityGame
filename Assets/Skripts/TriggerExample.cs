using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    public GameManager gm;
    public GameObject starEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            Instantiate (starEffect, new Vector3 (transform.position.x, transform.position.y+10, transform.position.z+2) ,transform.rotation);

            Destroy(other.gameObject);
            gm.AddScore();

        }
    
    }
}

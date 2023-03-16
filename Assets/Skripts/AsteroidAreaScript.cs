using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAreaScript : MonoBehaviour
{
    public GameObject [] spawner;
    public GameManager gameManager;

    public GameObject star;

    private void Start()
    {
        gameManager = GameObject.Find("GM").GetComponent<GameManager>();

        int rnd = Random.Range(0, 2);

        if(rnd == 1)
        {
            Instantiate(star, new Vector3 (transform.position.x, transform.position.y, transform.position.z+5), transform.rotation);
        }


    }




    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name == "Player")
        {
            for (int i = 0; i<spawner.Length; i++)
            {
                spawner[i].SetActive(true);
            }

            
          
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            gameManager.SpawnAsteroidField();
        }

    }

}

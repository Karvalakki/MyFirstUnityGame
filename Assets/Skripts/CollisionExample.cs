using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    public GameObject retryButton;
    public GameObject explosion;
    public GameObject explosion2;
    public GameObject quitButton;
    public Animator cameraAnim;
    //public GameObject thrusterEffect;


    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Obstacle")
        {
            //On collision hit changes player back to original position
            //transform.position = new Vector3 (-1.8f, 13.7f, 5.4f);
           
            StartCoroutine(HitStop());
        }
    }


    public IEnumerator HitStop()
    {
        Instantiate(explosion2, new Vector3(transform.position.x, transform.position.y + 20, transform.position.z), transform.rotation);
        Time.timeScale = 0.2f;
        yield return new WaitForSecondsRealtime(0.4f);
        Time.timeScale = 1f;
        Instantiate(explosion, new Vector3 (transform.position.x, transform.position.y+20, transform.position.z), transform.rotation);
        cameraAnim.SetTrigger("Shake");

        GameObject.Find("Rocket").SetActive(false);
        GameObject.Find("ThrusterEffect").SetActive(false);
        //thrusterEffect.SetActive(false);
        
        yield return new WaitForSecondsRealtime(0.2f);
        
        retryButton.SetActive(true);
        quitButton.SetActive(true);
        Destroy(gameObject);

    }
       
}

/*
GameObject.Find("Rocket").SetActive(false);
GameObject.Find("ThrusterEffect").SetActive(false);
GameObject.Find("ThrusterBoost").SetActive(false);
*/
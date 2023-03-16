using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample : MonoBehaviour
{

    public Animator myAnim;
    public GameObject boostEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            myAnim.SetBool("Boost", true);
            boostEffect.SetActive(true);
        }
        else
        {
            myAnim.SetBool("Boost", false);
            boostEffect.SetActive(false);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_the_ceiling : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space)) {
            int status = anim.GetInteger("status_num");
            //Debug.Log(status);
            if (status == 0) {
                anim.SetInteger("status_num", 1);
                anim.Play("celling moving");
            } else {
                anim.SetInteger("status_num", 0);
                anim.Play("right wall moving");
            }
        }
        */
    }
}

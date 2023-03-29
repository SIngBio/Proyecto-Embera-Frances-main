using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoWindowScript : MonoBehaviour
{

     private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
         anim = this.gameObject.GetComponent<Animator>();
         anim.SetBool("show",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

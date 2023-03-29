using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{

    public GameObject InfoWindow;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = InfoWindow.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInfoWindow(){
        anim.SetBool("show",true);
    }

    public void CloseInfoWindow(){
        anim.SetBool("show",false);
    }
}

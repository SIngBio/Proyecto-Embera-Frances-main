using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput: MonoBehaviour
{
    public string response;

    public GameObject fail;

    public GameObject success;

    public GameObject data;

    public Boolean isCorrect { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        this.isCorrect = false;
        this.fail.SetActive(false);
        this.success.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ReadStringInput(string s)
    {
        if (s == response)
        {
            this.isCorrect = true;
        }
        else
        {
            this.isCorrect = false;
        }
    }

    public void activateResponse(){
        if(this.isCorrect){
            this.success.SetActive(true);
            this.data.GetComponent<Main>().incrementPoints();
        }else {
            this.fail.SetActive(true);
        }
    }
}

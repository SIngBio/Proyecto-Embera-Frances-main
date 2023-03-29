using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;

public class WriteTest : MonoBehaviour
{
    public GameObject qOne;

    public GameObject qTwo;

    public GameObject qThree;

    public GameObject qFour;

    public GameObject qFive;

    public GameObject qSix;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Evaluate()
    {
        this.qOne.GetComponent<ReadInput>().activateResponse();
        this.qTwo.GetComponent<ReadInput>().activateResponse();
        this.qThree.GetComponent<ReadInput>().activateResponse();
        this.qFour.GetComponent<ReadInput>().activateResponse();
        this.qFive.GetComponent<ReadInput>().activateResponse();
        this.qSix.GetComponent<ReadInput>().activateResponse();
    }

    GameObject SetActive(string element, Boolean status)
    {
        GameObject elem = GameObject.Find(element);
        if (elem)
        {
            elem.SetActive (status);
        }
        return elem;
    }
}

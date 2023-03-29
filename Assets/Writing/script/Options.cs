using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject success;
    public GameObject fail;

    // Start is called before the first frame update
    void Start()
    {
        this.success.SetActive(false);
        this.fail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActiveSuccess()
    {
        StartCoroutine(this.waiterS());
    }

    public void ActiveFail()
    {
        StartCoroutine(this.waiterF());
    }

    IEnumerator waiterF()
    {
        this.fail.SetActive(true);
        yield return new WaitForSeconds(1);
        this.fail.SetActive(false);
    }

    IEnumerator waiterS()
    {
        this.success.SetActive(true);
        yield return new WaitForSeconds(1);
        this.success.SetActive(false);
    }
}

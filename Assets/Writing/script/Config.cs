using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
    }

    public void Restart()
    {
        SceneManager.LoadScene("Writing");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Interface");
    }

    public void Resume()
    {
        this.gameObject.SetActive(false);
    }

    public void ActivateMenu()
    {
        this.gameObject.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControles : MonoBehaviour
{
   public GameObject PanelMenu;
    public string Escena;
     public void Menu(){

        
            Time.timeScale = 0f;
            PanelMenu.SetActive(true);
       

    }

    public void reanudar(){
        Time.timeScale = 1f;
        PanelMenu.SetActive(false);
    }

 

    
}

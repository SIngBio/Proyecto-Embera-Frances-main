using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIPronunciacion : MonoBehaviour
{
  
    public GameObject panel;
    public GameObject palnelFrances;
   

  
    public void pasarFraces(){

        panel.SetActive(false);
         palnelFrances.SetActive(true);
    }

      public void  pasarEmbera(){
         palnelFrances.SetActive(false);
         panel.SetActive(true);
    }

    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            panel.SetActive(true);
        }
        

    }

    public void cerrar(){
        panel.SetActive(false);
        palnelFrances.SetActive(false);

    }
    
           
        
    }



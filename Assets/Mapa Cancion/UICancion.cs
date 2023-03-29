using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UICancion : MonoBehaviour
{
      public int Id;

    public GameObject panelEspañol;
    public GameObject panelFrances;
    public GameObject panelEmberra;


  
    public void pasarFraces(){
        panelEspañol.SetActive(false);
         panelEmberra.SetActive(false);
         panelFrances.SetActive(true);
    }

    public void  pasarEmbera(){
         panelEspañol.SetActive(false);
         panelFrances.SetActive(false);
         panelEmberra.SetActive(true);
    }
    public void  pasarEspañol(){
         panelFrances.SetActive(false);
         panelEmberra.SetActive(false);
         panelEspañol.SetActive(true);
    }

    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            panelEspañol.SetActive(true);
        }
        

    }

    public void cerrar(){
        panelEmberra.SetActive(false);
        panelFrances.SetActive(false);
        panelEspañol.SetActive(false);

    }
    public int GetId(){
         return Id;
    }           
        
    }



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informacion : MonoBehaviour
{

    public GameObject Panel;

    
     private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Panel.SetActive(true);
        }
        

    }

    public void cerrar()
    {
        Panel.SetActive(false);
        }
}

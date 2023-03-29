using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioDialogo : MonoBehaviour
{
    public List<PreguntasRespuestas> QnAux;
    public GameObject DialogoManager;

    public GameObject PanelQuiz;
 


    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            DialogoManager.GetComponent<DialogoManager>().totalQuestion = QnAux.Count;
            DialogoManager.GetComponent<DialogoManager>().QnA=QnAux;
            DialogoManager.GetComponent<DialogoManager>().generarQuestion();

            PanelQuiz.SetActive(true);
        }
        

    }

   

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestasScript : MonoBehaviour
{
   public bool isCorrect = false;
    public DialogoManager dialogoManager;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correcto");
            dialogoManager.correct();
        }
        else 
        {
            Debug.Log("Incorrecto");
            dialogoManager.wrong();
        }
    }
}

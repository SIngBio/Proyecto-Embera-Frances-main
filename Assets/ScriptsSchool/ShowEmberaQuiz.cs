using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowEmberaQuiz : MonoBehaviour
{
    public GameObject EmberaQuizMenu;

    public GameObject PopUpMenu;

    private Animator anim;

    private Text TextBtn1;
    private Text TextBtn2;
    private TMP_Text Question;

    public GameObject[] Btns;

    void Start(){
        anim = PopUpMenu.GetComponent<Animator>();
        TextBtn1 = PopUpMenu.GetComponentInChildren<PopUpMenu>().GetBtnText1();
        TextBtn2 = PopUpMenu.GetComponentInChildren<PopUpMenu>().GetBtnText2();
        Question = PopUpMenu.GetComponentInChildren<PopUpMenu>().GetQuestion();

    }

    public void Show(){
        if(this.gameObject.GetComponentInChildren<Text>().text == "Embera"){
            anim.SetBool("show",false);
            EmberaQuizMenu.SetActive(true);
            ShowBtns();
        }
       
    }

    public void ShowBtns(){
        foreach (GameObject Btn in Btns)
        {
            Btn.SetActive(true);
        }
    }

    public void Close(){

        if(PopUpMenu.GetComponentInChildren<PopUpMenu>().GetQuestion().text == "¿Deseas salir?" && 
        PopUpMenu.GetComponentInChildren<PopUpMenu>().GetBtnText1().text == "Sí"){
            
            EmberaQuizMenu.GetComponentInChildren<EmberaQuiz>().SetQuestionNumber(0);
            EmberaQuizMenu.GetComponentInChildren<EmberaQuiz>().SetFinished(false);
            EmberaQuizMenu.GetComponentInChildren<EmberaQuiz>().SetNumbCorrects(0);
            EmberaQuizMenu.SetActive(false);
        }
    }
}

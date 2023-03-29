using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowFrenchQuiz : MonoBehaviour
{
    public GameObject FrenchQuizMenu;

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
        if(this.gameObject.GetComponentInChildren<Text>().text == "Francés"){
            anim.SetBool("show",false);
            FrenchQuizMenu.SetActive(true);
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
        if(Question.text == "¿Deseas salir?" && TextBtn1.text == "Sí"){
            FrenchQuizMenu.GetComponentInChildren<FrenchQuiz>().SetQuestionNumber(0);
            FrenchQuizMenu.GetComponentInChildren<FrenchQuiz>().SetFinished(false);
            FrenchQuizMenu.GetComponentInChildren<FrenchQuiz>().SetNumbCorrects(0);
            FrenchQuizMenu.SetActive(false);
        }
    }
}

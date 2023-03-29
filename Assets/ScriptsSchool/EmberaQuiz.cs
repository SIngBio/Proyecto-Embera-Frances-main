using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EmberaQuiz : MonoBehaviour
{
    public TMP_Text TmpText;

    public Text[] OptionsText;

    private string[,] Answers = {
        {"Ârakîrumâ","humada","Sâka evarîsîdama"},
        {"Mupâtû","îbana","kababuma"},
        {"tuakidi",  "dua buma", "mâûde"},
        {"burukuku", "chorârâdrua", "karibu"},
        {"mipita", "Arabuma", "Kîrajû"},
        {"Sâka duanuma kevara", "humada", "Sâ ebarîsîdama"},
        {"ôpubuta", "vaturîkî", "chorârâdrua"},
        {"drua",  "mîpîta",  "Arabuma"},
        {"Arakiruma",  "humada" ,"vûmparanê"},};
   
    private string[] Questions = { "Buenos días en Embera se dice ... ", 
    "El pájaro en Embera", "Andar en Embera", "Cantar en Embera", "Bonito en Embera" , 
    "Buenas tardes en Embera", "Ancestral en Embera", "Territorio en Embera","Muchas gracias en Embera"};


    private int QuestionNumber = 0;

    private const int MaxNumberQuestions = 9;

    private bool finished = false;

    private int NumbCorrects = 0;

    public GameObject[] Btns;

    public TMP_Text currentResult;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
            if(!finished){
                TmpText.text = Questions[QuestionNumber];
            
                for (int i = 0; i < Answers.GetLength(1) ; i++)
                {
                    OptionsText[i].text = Answers[QuestionNumber,i];
                }

                if(currentResult!=null){
                    float embera_result = ((float) NumbCorrects/ MaxNumberQuestions)*100;
                    currentResult.text = Math.Round(embera_result)  + "%";
                }
            }
            else{
                ShowResults();
            }

    }

    private void ShowResults(){
        
        float result = ((float) NumbCorrects/ MaxNumberQuestions)*100;
        TmpText.text = "Resultado Final " + Math.Round(result)  + "%";
        HideBtns();
        currentResult.text = "0%";

    }

    private void HideBtns(){
        foreach (GameObject Btn in Btns)
        {
            Btn.SetActive(false);
        }
    }

    public int GetQuestionNumber(){
        return QuestionNumber;
    }

    public void SetQuestionNumber(int NewQuestionNumber){
        if(NewQuestionNumber < MaxNumberQuestions){
            QuestionNumber = NewQuestionNumber;
        }
        else{
            finished = true;
        }
    }

    public void SetFinished(bool NewFinished){
        finished = NewFinished;
    }

    public void SetNumbCorrects(int NewNumb){
        this.NumbCorrects = NewNumb;
    }
}

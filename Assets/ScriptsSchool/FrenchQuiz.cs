using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FrenchQuiz : MonoBehaviour
{
    public TMP_Text TmpText;

    public Text[] OptionsText;

    private string[,] Answers = {
        {"Bonjour","Au revoir","A tout à l’heure"},
        {"Truite", "Tigre" , "Oiseau"},
        {"Courir",  "Se promener", "Regarder"},
        {"Chanter", "Crier", "Parler"},
        {"Magnifiquement", "Sûrement", "Expressément"},
        {"Bonsoir", "Bon Après-midi", "Surtout"},
        {"Autrefois", "Avant", "Ancestral"},
        {"Chemin",  "Territoire",  "Ville"},
        {"S’il te plaît",  "Encore une fois" ,"Merci beaucoup"},
        { "merveilleusement grand", "très heureux" , "génial"}};
   
    private string[] Questions = { "Buenos días en Francés se dice ... ", 
    "El pájaro en frances", "Andar en francés", "Cantar en francés", "Bonito en francés" , 
    "Buenas tardes en francés", "Ancestral en francés", "Territorio en francés","Muchas gracias en francés",
    "Muy feliz en francés" };


    private int QuestionNumber = 0;

    private const int MaxNumberQuestions = 10;

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
                    currentResult.text = ((float) NumbCorrects/ MaxNumberQuestions)*100 + "%";
                }
            }
            else{
                ShowResults();
            }

    }

    private void ShowResults(){
        
        float result = ((float) NumbCorrects/ MaxNumberQuestions)*100;
        TmpText.text = "Resultado Final " + result  + "%";
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

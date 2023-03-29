using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidateAnswersScript : MonoBehaviour
{

    private string[] CorrectAnswers = {"Bonjour", "Oiseau","Se promener","Chanter","Magnifiquement",
    "Bon Après-midi" , "Ancestral", "Territoire" ,"Merci beaucoup","très heureux"};

    public GameObject FrenchQuizObject;

    private FrenchQuiz Quiz;

    private int QuestionNumber;

    private Text TextBtn;

    private static int NumbCorrects = 0;

    private Image MyImage;

    public Button[] Btns = {};

    // Start is called before the first frame update
    void Start()
    {
        if(FrenchQuizObject.GetComponent<FrenchQuiz>() != null){
            QuestionNumber = FrenchQuizObject.GetComponent<FrenchQuiz>().GetQuestionNumber();
            Quiz = FrenchQuizObject.GetComponent<FrenchQuiz>();
            TextBtn = this.gameObject.GetComponentInChildren<Text>();
            MyImage = this.gameObject.GetComponent<Image>();
            NumbCorrects = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateAnswer(){
        QuestionNumber = Quiz.GetQuestionNumber();
       
        if(CorrectAnswers[QuestionNumber] == TextBtn.text){
            NumbCorrects++;
            Quiz.SetNumbCorrects(NumbCorrects);
            print(NumbCorrects);
        }
        DisableButtons();
    }

    public void NextQuestion(){
        Quiz.SetQuestionNumber(Quiz.GetQuestionNumber() + 1);
        ResetColorButtons();
        
    }

    private void DisableButtons(){
        foreach (Button Btn in Btns)
        {
            if(Btn.GetComponentInChildren<Text>().text == CorrectAnswers[QuestionNumber]){
                Btn.GetComponent<Image>().color = Color.blue;
            }
            else{
                Btn.GetComponent<Image>().color = Color.red;
            }
            Btn.interactable = false;
        }
    }

    private void ResetColorButtons(){
        foreach (Button Btn in Btns)
        {
            Btn.GetComponent<Image>().color = Color.white;
            Btn.interactable = true;
        }
    }
}

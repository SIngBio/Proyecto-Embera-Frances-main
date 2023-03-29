using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    private bool isPlayerInRange =false;
    [SerializeField] private float VText;
    public GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField,TextArea(4,6)] private string[]  dialogueLines;
        private bool ButtonAClick;

    private bool didDialogueStart = false;
    private int lineText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(isPlayerInRange)
        {
            if(Input.GetKeyDown("space")){

                    if(!didDialogueStart){
                       StartDailogue();

                    }else if(dialogueText.text==dialogueLines[lineText])
                    {
                        NextDailogue();
                    }
                    else{
                        StopAllCoroutines();
                        dialogueText.text=dialogueLines[lineText];
                    }
            }
             

            
        }
    }
    

    private void TaskOnClick(){
       
    }
    private void StartDailogue(){
        didDialogueStart=true;
        lineText=0;
        StartCoroutine(ShowLine());

    }
    private void NextDailogue(){

        lineText++;
        if(lineText<dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }else{
            didDialogueStart=false;
            dialoguePanel.SetActive(false);
        }
        

    }
    private IEnumerator ShowLine()
    {
        dialogueText.text= string.Empty;
        foreach(char ch in dialogueLines[lineText])
        {
            dialogueText.text+=ch;
            yield return new WaitForSeconds(VText);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            dialoguePanel.SetActive(true);

            isPlayerInRange=true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
                        dialoguePanel.SetActive(false);

            isPlayerInRange=false;
        } 
    }
}

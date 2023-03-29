using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListCoint : MonoBehaviour
{
  public Dictionary<string, GameObject> Coints = new Dictionary<string, GameObject>();
    public List<GameObject>  Coint ;
     List<string> cointId ; 
    public Dropdown m_Dropdown;    
    void Start()
    {
       m_Dropdown.ClearOptions();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("CoinMusic") ){
            string textId="Libro " + collision.gameObject.GetComponent<UICancion>().GetId().ToString();
            Coints.Add(textId,collision.gameObject);
            m_Dropdown.options.Add (new Dropdown.OptionData() {text=textId});
            collision.gameObject.SetActive(false);

                 }
    }
    private void OnTriggerExit2D(Collider2D collision){
        
    }
    public  Dictionary<string, GameObject> GetCoints(){
         return Coints;
    
        }
}

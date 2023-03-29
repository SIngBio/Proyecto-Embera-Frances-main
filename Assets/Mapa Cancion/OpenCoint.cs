using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCoint : MonoBehaviour
{
    public Dropdown m_Dropdown;    

    public GameObject  Player ;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void openCointPanel(){
        Player.GetComponent<ListCoint>().GetCoints()[m_Dropdown.options[m_Dropdown.value].text].GetComponent<UICancion>().pasarEspañol();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

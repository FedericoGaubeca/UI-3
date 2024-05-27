using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoginManager : MonoBehaviour
{
    //public Text accesGrantedTxt;
    //public Text accesDeniedTxt;
    public Text inputText;

    public string password;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void Acept()
    {
        if(inputText.text == password) //ElPepe123
        {
            Debug.Log("Acces Granted");
        } else { Debug.Log("Acces Denied"); }
    }
}

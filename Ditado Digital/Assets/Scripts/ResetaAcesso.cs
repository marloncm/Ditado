using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetaAcesso : MonoBehaviour
{
    public Text NameBox;
   // private int a;

    //a = PlayerPrefs.GetInt("PrimeiroAcesso");//.ToString(); 
    // Start is called before the first frame update
    void Start()
    {
       NameBox.text = PlayerPrefs.GetInt("PrimeiroAcesso").ToString();
    }
}
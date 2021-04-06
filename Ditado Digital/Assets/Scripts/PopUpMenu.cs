using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour
{
    [Header("Seleção")]
    public GameObject menuPanel1;
    [Header("Confirma")]
    public GameObject menuPanel2;
  
   [Header("botão1")]
    public GameObject bot1;
    [Header("botão2")]
    public GameObject bot2;
     [Header("botão3")]
    public GameObject bot3;
     [Header("botão4")]
    public GameObject bot4;
    [Header("botão5")]
    public GameObject bot5;
        
void Start() { 
menuPanel2.SetActive(false);
    }


public void abremenu(){
menuPanel2.SetActive(true);
bot1.SetActive(false);
bot2.SetActive(false);
bot3.SetActive(false);
bot4.SetActive(false);
bot5.SetActive(false);
}

 
public void fechamenu(){
menuPanel2.SetActive(false);
bot1.SetActive(true);
bot2.SetActive(true);
bot3.SetActive(true);
bot4.SetActive(true);
bot5.SetActive(true);
}


public void confirmapersonagem(){
menuPanel2.SetActive(true);
menuPanel1.SetActive(false);
}
public void cancelapersonagem(){
menuPanel2.SetActive(false);
menuPanel1.SetActive(true);
}

}

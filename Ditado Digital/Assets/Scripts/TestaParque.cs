using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestaParque: MonoBehaviour
{

[SerializeField]
private InputField textoField = null;

[SerializeField]
private Text feedbackmsg = null;

public string cena = string.Empty ;
public string palavra = "";
private int erros = 0;
private int errosparque = 0;
private int acertos = 0;
public GameObject frasebolha;
private float f=1f;

void Start() 
{
   frasebolha.SetActive(false); 
   errosparque = PlayerPrefs.GetInt("errosparque");
   acertos = PlayerPrefs.GetInt("acertosparque");
}


public void TestaInput()
{
string digitado = textoField.text;

    if(digitado.ToUpper() != palavra.ToUpper() )
        {
            erros++;
            if(erros == 1)
            {
                frasebolha.SetActive(true); 
            feedbackmsg.CrossFadeAlpha(100f, 0f, false);
            feedbackmsg.color = Color.red;
            feedbackmsg.text = "Escute novamente a palavra!";
            feedbackmsg.CrossFadeAlpha(0f, 10f, false);
            textoField.text = "";
            desligabolha();
            }
            else if (erros == 2)
            {
                frasebolha.SetActive(true); 
            feedbackmsg.CrossFadeAlpha(100f, 0f, false);
            feedbackmsg.color = Color.red;
            feedbackmsg.text = "Está tudo bem! Escute a palavra novamente.";
            feedbackmsg.CrossFadeAlpha(0f, 10f, false);
            textoField.text = "";
            desligabolha();
            }else if(erros > 2)
        {
         frasebolha.SetActive(true); 
        feedbackmsg.CrossFadeAlpha(100f, 0f, false);
        feedbackmsg.color = Color.black;
        feedbackmsg.text = $"A palavra é: {palavra}. Agora você pode digitar a palavra!";
        }


        }else
        {
            if(erros == 0)
            {
                acertos++;
                PlayerPrefs.SetInt("acertosparque", acertos);
            }else erros=1;
            errosparque = errosparque + erros;
            PlayerPrefs.SetInt("errosparque", errosparque);
            frasebolha.SetActive(true); 
            PlayerPrefs.SetInt("erros", erros);
            feedbackmsg.CrossFadeAlpha(100f, 0f, false);
            feedbackmsg.color = Color.green;
            feedbackmsg.text = "Parabéns! Ótimo trabalho!";
            PlayerPrefs.Save();
            StartCoroutine(CarregaCena());
            }    
}


IEnumerator CarregaCena()
{
yield return new WaitForSeconds(3);
SceneManager.LoadScene(cena);
}



    IEnumerator desligabolha()
     {
            yield return new WaitForSeconds(f);
            frasebolha.SetActive(false);
     }



}

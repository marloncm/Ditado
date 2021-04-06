using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MudaRoupa : MonoBehaviour
{

[Header("Sprite Principal")]
public SpriteRenderer pcorpo;

[Header("Sprites para mudar")]
public List<Sprite> opcoes = new List<Sprite>();

 private int index = 0;


 public void Prox()
 {
index++;
 if(index >= opcoes.Count)
    {
        index = 0;
    }
pcorpo.sprite = opcoes[index];
 }


 public void Prev()
 {
index--;
 if(index <= 0)
    {
        index = opcoes.Count - 1;
    }
pcorpo.sprite = opcoes[index];
 }

public void Randomizar()
{
index = Random.Range(0, opcoes.Count - 1);
pcorpo.sprite = opcoes[index];
}

//MODO CERTO DE SALVAR O PERSONAGEM
    
public void SalvaCabelo()
{
PlayerPrefs.SetInt("Cabelo", index);
PlayerPrefs.Save();
}

public void SalvaOlho()
{
PlayerPrefs.SetInt("Olho", index);
PlayerPrefs.Save();
}

public void SalvaPele()
{
PlayerPrefs.SetInt("Pele", index);
PlayerPrefs.Save();
}

public void SalvaRoupa()
{
PlayerPrefs.SetInt("Roupa", index);
PlayerPrefs.Save();
}




}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//COMO CARREGAR O PERSONAGEM NO CENARIO
public class LoadPlayer : MonoBehaviour
{
    private int cabelo;
    private int olho;
    private int pele;
    private int roupa;

//AQUI VAI O PERSONAGEM PRÉ MONTADO
[Header("Cabeça Main")]
public SpriteRenderer pcabelo;

[Header("Olhos Main")]
public SpriteRenderer polho;

[Header("Pele Main")]
public SpriteRenderer ppele;

[Header("Roupa Main")]
public SpriteRenderer proupa;


//SAVAR AQUI OS SPRITES PARA MUDAR
    [Header("Cabelos")]
    public List<Sprite> cabeloses = new List<Sprite>();


    [Header("Olhos")]
    public List<Sprite> olhoses = new List<Sprite>();


    [Header("Peles")]
    public List<Sprite> peleses = new List<Sprite>();


    [Header("Roupas")]
    public List<Sprite> roupases = new List<Sprite>();




//COLOCAR ESSE SCRIPT EM QUALQUER OBJETO
    void Start()
    {
    cabelo = PlayerPrefs.GetInt("Cabelo");
    olho = PlayerPrefs.GetInt("Olho");
    pele = PlayerPrefs.GetInt("Pele");
    roupa = PlayerPrefs.GetInt("Roupa");



        pcabelo.sprite = cabeloses[cabelo];

        polho.sprite = olhoses[olho];

        ppele.sprite = peleses[pele];

        proupa.sprite = roupases[roupa];  
    }


}

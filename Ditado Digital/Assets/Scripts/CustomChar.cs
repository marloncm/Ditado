using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CustomChar : MonoBehaviour
{
    public GameObject personagem;

    public List<MudaRoupa> roupas = new List<MudaRoupa>();


    public void RandomizeChar()
    {
        foreach (MudaRoupa changer in roupas)
        {
            changer.Randomizar();
        }

    }


/*      MODO ERRADO
      public void confirma()
{
PrefabUtility.SaveAsPrefabAsset(personagem, "Assets/Sprites/Personagens/Player.prefab");
}
  */
    
}

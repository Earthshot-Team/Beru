using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Word Data", menuName = "Literacy/Word", order = 2)]
public class WordData : ScriptableObject
{
    public string word;

    public Texture2D icon;

    public int GetNumOfCharactersInWord()
    {
        return word.Length;
    } 
}
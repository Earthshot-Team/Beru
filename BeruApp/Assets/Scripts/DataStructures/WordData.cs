using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Word Data", menuName = "Literacy/Word", order = 2)]
public class WordData : ScriptableObject
{
    // VARIABLES
    [SerializeField] private string word;

    public Texture2D icon;

    // PROPERTIES
    public string Word
    {
        get => word.ToLower();
    }

    // METHODS
    public int GetNumOfCharactersInWord()
    {
        return word.Length;
    } 
}
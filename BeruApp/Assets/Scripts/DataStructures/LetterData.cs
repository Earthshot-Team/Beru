using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Letter Data", menuName = "Literacy/Letter", order = 1)]
public class LetterData : ScriptableObject
{
    [SerializeField] private char _character; // FIELD

    public char character
    {
        get => char.ToLower(_character);
    } // PROPERTY

    public Texture2D untracedSprite;
    public Texture2D tracedSprite;
}

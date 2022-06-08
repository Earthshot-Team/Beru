using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Letter Data", menuName = "Literacy/Letter", order = 1)]
public class LetterData : ScriptableObject
{
    [SerializeField] private char _character; // FIELD

    public Texture2D untracedSprite;
    public Texture2D tracedSprite;

    public char Character
    {
        get => char.ToLower(_character);
    } // PROPERTY
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Alphabet Data", menuName = "Literacy/Alphabet", order = 4)]
public class AlphabetData : ScriptableObject
{
    [SerializeField] private LetterData[] _letters; // FIELD

    public LetterData[] Letters
    {
        get => _letters;
    } // PROPERTY

    public LetterData GetLetterDataFromCharacter(char letter)
    {
        foreach (LetterData letterData in _letters)
        {
            if (letter == letterData.Character)
            {
                return letterData;
            }
        }

        return _letters[0];
    }
}

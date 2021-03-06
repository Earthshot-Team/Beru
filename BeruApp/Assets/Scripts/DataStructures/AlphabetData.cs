using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Alphabet Data", menuName = "Literacy/Alphabet", order = 4)]
public class AlphabetData : ScriptableObject
{
    // VARIABLES
    [SerializeField] private LetterData[] _letters;

    // PROPERTIES
    public LetterData[] Letters
    {
        get => _letters;
    }

    // METHODS
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

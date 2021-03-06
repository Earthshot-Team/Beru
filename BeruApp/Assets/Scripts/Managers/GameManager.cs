using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // VARIABLES
    [Header("Game Settings")]

    [SerializeField] private WordBankData wordBank;
    [SerializeField] private int numOfWords;
    [SerializeField] private WordData[] words;
    [SerializeField] private AlphabetData language;

    [Header("Game Variables")]
    [SerializeField] private int currentWordIndex = 0;

    // PROPERTIES
    public WordData CurrentWordData => words[currentWordIndex];
    public AlphabetData Language { get => language; }

    // METHODS
    private void Awake()
    {
        words = GetXRandomWords(numOfWords);
    }

    WordData[] GetXRandomWords(int x)
    {
        if(x > wordBank.words.Length)
        {
            Debug.Log("Not Enough Words In Bank", this);
            return wordBank.words;
        }

        List<WordData> tempList = new List<WordData>();

        for (int i = 0; i < numOfWords; i++)
        {
            WordData word = wordBank.GetRandomWord();
            while (tempList.Contains(word))
            {
                word = wordBank.GetRandomWord();
            }

            tempList.Add(word);
        }

        return tempList.ToArray();
    }
}

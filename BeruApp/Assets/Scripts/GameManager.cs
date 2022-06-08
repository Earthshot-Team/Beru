using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game Settings")]

    [SerializeField] private WordBankData wordBank;
    [SerializeField] private int numOfWords;
    [SerializeField] private WordData[] words;

    [Header("Game Variables")]
    [SerializeField] private int currentWordIndex = 0;
    public WordData currentWordData => words[currentWordIndex]; // PROPERTY

    private void Start()
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

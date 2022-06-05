using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private WordBankData wordBank;

    [SerializeField] private int numOfWords;

    [SerializeField] private WordData[] words;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    WordData[] GetXRandomWords(int x)
    {
        /*for (int i = 0; i < numOfWords; i++)
        {
            int rand = Random.Range(0, wordBank.words.Length);
        }*/

        return wordBank.words;
    }
}

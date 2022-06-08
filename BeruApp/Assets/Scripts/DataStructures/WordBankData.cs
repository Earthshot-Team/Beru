using UnityEngine;

[CreateAssetMenu(fileName = "Word Bank Data", menuName = "Literacy/Word Bank", order = 3)]
public class WordBankData : ScriptableObject
{
    // VARIABLES
    public WordData[] words;

    // METHODS
    public WordData GetRandomWord()
    {
        int rand = Random.Range(0, words.Length);
        return words[rand];
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "Word Bank Data", menuName = "Literacy/Word Bank", order = 2)]
public class WordBankData : ScriptableObject
{
    public WordData[] words;

    public WordData GetRandomWord()
    {
        int rand = Random.Range(0, words.Length);
        return words[rand];
    }
}

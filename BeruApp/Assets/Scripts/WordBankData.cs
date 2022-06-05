using UnityEngine;

[CreateAssetMenu(fileName = "Word Bank Data", menuName = "Literacy/Word Bank", order = 2)]
public class WordBankData : ScriptableObject
{
    public WordData[] words;
}

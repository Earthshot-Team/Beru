using UnityEngine;

[CreateAssetMenu(fileName = "Letter Data", menuName = "Literacy/Letter", order = 0)]
public class LetterData : ScriptableObject
{
    public char character;

    public Texture2D untracedSprite;
    public Texture2D tracedSprite;
}

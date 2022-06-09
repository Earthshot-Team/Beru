using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Letter Data", menuName = "Literacy/Letter", order = 1)]
public class LetterData : ScriptableObject
{
    // VARIABLES
    [SerializeField] private char _character; // FIELD

    public Texture2D untracedTexture;
    public Texture2D tracedTexture;

    // PROPERTIES
    public char Character
    {
        get => char.ToLower(_character);
    }
    public Sprite UntracedSprite
    {
        get
        {
            return TurnTextureToSprite(untracedTexture);
        }
    }
    public Sprite TracedSprite
    {
        get
        {
            return TurnTextureToSprite(tracedTexture);
        }
    }

    // METHODS
    private Sprite TurnTextureToSprite(Texture2D texture)
    {
        Rect rec = new Rect(0, 0, texture.width, texture.height);
        int pixelsPerUnit = 100;
        Vector2 bottomLeftCorner = new Vector2(0, 0);

        return Sprite.Create(texture, rec, bottomLeftCorner, pixelsPerUnit);
    }
}

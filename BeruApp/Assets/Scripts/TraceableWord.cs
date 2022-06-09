using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceableWord : MonoBehaviour
{
    // VARIABLES
    [SerializeField] private WordData wordData;
    [SerializeField] private AlphabetData alphabet;
    [SerializeField] private int bufferBtwLetters;
    [SerializeField] private Vector3 instantiatePos;
    [SerializeField] private List<GameObject> myLetters = new List<GameObject>();

    // PROPERTIES
    public string Text => wordData.Word;
    public char[] Characters => Text.ToCharArray();
    public LetterData[] Letters
    {
        get
        {
            List<LetterData> letterDatas = new List<LetterData>();
            foreach (char item in Characters)
            {
                letterDatas.Add(alphabet.GetLetterDataFromCharacter(item));
            }

            return letterDatas.ToArray();
        }
    }

    // CONSTRUCTORS
    public TraceableWord (WordData data)
    {
        wordData = data;
    }

    // METHODS
    private void Start()
    {
        foreach (LetterData letter in Letters)
        {
            ConstructLetterObject(letter, instantiatePos);
        }

        CenterAllMyLetters();
    }

    void ConstructLetterObject(LetterData data, Vector3 pos)
    {
        GameObject obj = new GameObject("LetterObject " + data.Character.ToString());

        /*SpriteRenderer spriteRend = obj.AddComponent<SpriteRenderer>();
        spriteRend.sprite = data.UntracedSprite;*/

        Mesh mesh = SpriteToMesh(data.UntracedSprite);
        mesh.name = data.Character.ToString() + " Mesh";

        MeshFilter meshFilter = obj.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer>();

        obj.transform.SetParent(this.transform);
        obj.transform.localPosition = pos;
        obj.transform.localScale = Vector3.one;

        instantiatePos.x += (data.untracedTexture.width / 100f) + bufferBtwLetters;

        myLetters.Add(obj);
    }
    void CenterAllMyLetters()
    {
        foreach (var item in myLetters)
        {
            item.transform.localPosition -= new Vector3((instantiatePos.x - bufferBtwLetters) / 2, 0, 0); 
        }
    }

    Mesh SpriteToMesh(Sprite sprite)
    {
        Mesh mesh = new Mesh();
        mesh.vertices = Array.ConvertAll(sprite.vertices, i => (Vector3)i);
        mesh.uv = sprite.uv;
        mesh.triangles = Array.ConvertAll(sprite.triangles, i => (int)i);

        return mesh;
    }
}

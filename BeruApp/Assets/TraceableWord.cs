using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceableWord : MonoBehaviour
{
    // VARIABLES
    [SerializeField] WordData wordData;

    // PROPERTIES
    public string Text => wordData.word;
    public char[] Characters => Text.ToCharArray();

    // CONSTRUCTORS
    public TraceableWord (WordData data)
    {
        wordData = data;
    }

    // METHODS
    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}

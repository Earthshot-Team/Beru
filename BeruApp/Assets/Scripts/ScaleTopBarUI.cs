using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScaleTopBarUI : MonoBehaviour
{
    [SerializeField] private string word;

    [Header("Text")]
    [SerializeField] private RectTransform textTransform;
    [SerializeField] private TMP_Text textComponent;

    [Header("Text Scaling")]
    [SerializeField] private float textBuffer = 30f;
    [SerializeField] private float textSizeY = 75f;

    private void Start()
    {
        textComponent.text = word;
        ReloadTextBoxSize();
    }

    public void ReloadTextBoxSize()
    {
        Vector2 textSize = textComponent.GetPreferredValues(word);
        textTransform.sizeDelta = new Vector2(textSize.x + (textBuffer * 2), textSizeY);
    }
}

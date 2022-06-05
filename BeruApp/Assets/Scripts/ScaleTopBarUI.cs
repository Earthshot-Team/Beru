using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class ScaleTopBarUI : MonoBehaviour
{
    [SerializeField] private string word;

    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private Image leftLine;
    [SerializeField] private Image rightLine;

    void Start()
    {
        text.text = word;
    }

    void Update()
    {
        text.text = word;
    }

}

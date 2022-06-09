using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectHuntingUIHandler : MonoBehaviour, IDoSomethingOnPhaseChange
{
    // VARIABLES
    private GameManager gameManager;

    [Header("Text")]
    [SerializeField] private TMP_Text textComponent;

    // PROPERTIES
    public string word => gameManager.CurrentWordData.Word.ToUpper();

    // METHODS
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        SetText();
    }

    public void PhaseChange(GamePhase oldPhase, GamePhase newPhase)
    {
        if(oldPhase == GamePhase.HuntingForObject)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetText()
    {
        textComponent.text = word;
    }
}

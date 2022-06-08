using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Refactor This Script -> Find better name
public class ObjectHuntingUIHandler : MonoBehaviour, IDoSomethingOnPhaseChange
{
    private GameManager gameManager;
    
    public string word => gameManager.CurrentWordData.word.ToUpper();

    [Header("Text")]
    [SerializeField] private TMP_Text textComponent;

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

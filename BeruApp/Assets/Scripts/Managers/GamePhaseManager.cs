using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles Which Objects / Components are on or off depending on the current phase of the game. Also stores the current Phase of the game.
public class GamePhaseManager : MonoBehaviour
{
    [SerializeField] private GamePhase _phase = GamePhase.HuntingForObject;

    public GamePhase phase
    {
        get => _phase;
        set
        {
            _phase = value;
        }
    }

    public void SetPhase(int phaseNumber)
    {
        switch ((GamePhase)phaseNumber) // use upcast, where 0 - first, 1 - second...
        {
            case (GamePhase.HuntingForObject):
                phase = GamePhase.HuntingForObject;
                break;
            case (GamePhase.SearchingForWall):
                phase = GamePhase.SearchingForWall;
                break;
            case (GamePhase.TracingLetters):
                phase = GamePhase.TracingLetters;
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles Which Objects / Components are on or off depending on the current phase of the game. Also stores the current Phase of the game.
public class GamePhaseManager : MonoBehaviour
{
    [SerializeField] private GamePhase phase = GamePhase.HuntingForObject;

    public void ChangePhaseTo(GamePhase _phase)
    {
        phase = _phase;
    }
    
    public GamePhase GetCurrentPhase()
    {
        return phase;
    }
}

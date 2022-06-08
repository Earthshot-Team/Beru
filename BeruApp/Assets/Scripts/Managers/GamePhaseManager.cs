using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Niantic.ARDK.Extensions;

public class GamePhaseManager : MonoBehaviour, IDoSomethingOnPhaseChange
{
    [SerializeField] private GamePhase _phase = GamePhase.HuntingForObject;

    [SerializeField] private GameObject planeManager;

    public GamePhase phase
    {
        get => _phase;
        set
        {
            // This Kills Performance, But We Will See if it ever becomes a big deal.
            var ss = FindObjectsOfType<MonoBehaviour>().OfType<IDoSomethingOnPhaseChange>();
            foreach (IDoSomethingOnPhaseChange s in ss)
            {
                s.PhaseChange(_phase, value);
            }
            _phase = value;
        }
    }

    public void PhaseChange(GamePhase oldPhase, GamePhase newPhase)
    {
        if(newPhase == GamePhase.HuntingForObject)
        {
            planeManager.GetComponent<ARPlaneManager>().enabled = false;
        }

        if (newPhase == GamePhase.SearchingForWall)
        {
            planeManager.GetComponent<ARPlaneManager>().enabled = true;
        }

        if (newPhase == GamePhase.TracingLetters)
        {

        }
    }

    public void SetPhase(int phaseNumber)
    {
        switch ((GamePhase)phaseNumber) // turning number into GamePhase state
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
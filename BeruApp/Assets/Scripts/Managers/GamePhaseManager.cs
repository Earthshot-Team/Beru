using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Niantic.ARDK.Extensions;

public class GamePhaseManager : MonoBehaviour, IDoSomethingOnPhaseChange
{
    [SerializeField] private GamePhase phase = GamePhase.HuntingForObject;

    [SerializeField] private GameObject planeManager;

    public GamePhase Phase
    {
        get => phase;
        set
        {
            // This Kills Performance, But We Will See if it ever becomes a big deal.
            var ss = FindObjectsOfType<MonoBehaviour>().OfType<IDoSomethingOnPhaseChange>();
            foreach (IDoSomethingOnPhaseChange s in ss)
            {
                s.PhaseChange(phase, value);
            }
            phase = value;
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
                Phase = GamePhase.HuntingForObject;
                break;
            case (GamePhase.SearchingForWall):
                Phase = GamePhase.SearchingForWall;
                break;
            case (GamePhase.TracingLetters):
                Phase = GamePhase.TracingLetters;
                break;
        }
    }
}

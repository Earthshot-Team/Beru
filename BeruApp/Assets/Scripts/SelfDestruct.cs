using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // VARIABLES
    public float lifetime;

    // METHODS
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_InstantiateObject : MonoBehaviour
{ 
    // METHODS
    public void CreateObjectAtZeroZero(GameObject gameObject)
    {
        Object.Instantiate(gameObject, Vector3.zero, Quaternion.identity);
    }
}

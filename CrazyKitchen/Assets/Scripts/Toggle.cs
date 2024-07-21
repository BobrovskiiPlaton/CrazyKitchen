using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;
    public KeyCode toggleKey;
    private bool isInitialState = true;
    void Start()
    {
        objectToActivate.SetActive(false);
        objectToDeactivate.SetActive(true);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            isInitialState = !isInitialState;
            objectToActivate.SetActive(!isInitialState);
            objectToDeactivate.SetActive(isInitialState);
        }
    }
}

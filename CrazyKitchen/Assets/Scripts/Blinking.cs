using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinking : MonoBehaviour
{
    public float interval = 1.5f;
    [SerializeField] private GameObject _gameObject;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            _gameObject.SetActive(!_gameObject.activeSelf);
            timer = 0;
        }
    }
}

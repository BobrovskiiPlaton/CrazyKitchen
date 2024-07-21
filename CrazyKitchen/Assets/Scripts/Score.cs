using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int total = 0;
    public string name;
    public TMP_Text scoreText;
    
    void Update()
    {
        scoreText.text = total.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == name)
        {
            Destroy(collision.gameObject);
            total++;
        }
        else
        {
            Destroy(collision.gameObject);
            total--;
            if (total <= 0)
                total = 0;
        }
    }
}

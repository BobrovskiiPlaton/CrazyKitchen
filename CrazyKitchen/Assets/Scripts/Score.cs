using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int total = 0;
    public string name;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == name)
        {
            Destroy(collision.gameObject);
            total++;
            Debug.Log("Score: " + total);
        }
        else
        {
            Destroy(collision.gameObject);
            total--;
            if (total <= 0)
                total = 0;
            Debug.Log("Score: " + total);
        }
    }
}

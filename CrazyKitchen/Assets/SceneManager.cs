using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    [SerializeField] private string nextScene;

    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
        Time.timeScale = 1f;
    }
}

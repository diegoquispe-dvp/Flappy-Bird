using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject CanvasLoss;
    void Start()
    {
        Time.timeScale = 1;

    }

    
    void Update()
    {
        
    }

    public void YouLoss()
    {
        CanvasLoss.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}



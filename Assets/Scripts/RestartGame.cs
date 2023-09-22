using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject _panelOn;
    public void QuitGame() {
        {
            Application.Quit();
        }
    }
    public void Restart(){
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void OffGameObj()
    {
        _panelOn.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject photoCards;

    public void GameOver(){
        photoCards.SetActive(true);
    }

    public void RestartGame(){
        SceneManager.LoadScene(0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogForTutorial : MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text dialogText;
    public GameObject[] _gameObj;
    public GameObject _panelOn;
    

    private int index;
    private int countIcon = 0;
    void Start()
    {
        dialogText.text = string.Empty;
        StartDialog();
        _gameObj[0].SetActive(true);
        for(int i = 1; i < _gameObj.Length; i++)
        {
            _gameObj[i].SetActive(false);
        }
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void skipText()
    {
        if (dialogText.text == lines[index])
        {
            if (countIcon + 1 != _gameObj.Length)
            {
                CloseIcon();
            }
            else
            {
                _panelOn.SetActive(true);
            }
            NextLines();
            
        }
        else
        {
            StopAllCoroutines();
            dialogText.text = lines[index];
        }
    }

    public void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogText.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void CloseIcon()
    {
        
            _gameObj[countIcon].SetActive(false);
            _gameObj[countIcon + 1].SetActive(true);
            countIcon += 1;
         
      
    }

    public void OnClickNewScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}

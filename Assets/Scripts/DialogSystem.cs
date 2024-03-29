using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text dialogText;
    public Text nameText;
    public GameObject _panelOut;

    private int index;
    private bool _checkTLM = false;

    void Start()
    {
        dialogText.text = string.Empty;
        StartDialog();
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            dialogText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void skipText()
    {
        
        if (_checkTLM == true)
        {
            if (dialogText.text == lines[index])
            {
                NextLines();
                NameChange();
            }
            else
            {
                StopAllCoroutines();
                dialogText.text = lines[index];
            }
        }
    }

    public void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogText.text =string.Empty;
            StartCoroutine (TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
            _panelOut.SetActive(true);
        }
    }


    public void NameChange()
    {
        if(index % 2 == 0)
        {
            nameText.text = "���������";
        }
        else
        {
            nameText.text = "����";
        }
    }

    public void CheckTLM()
    {
        _checkTLM = true;
    }

}

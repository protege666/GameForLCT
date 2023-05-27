using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelOn : MonoBehaviour
{
    public Animator anim;
    public GameObject panel;
    public GameObject backButton;
    public GameObject panelButton;
    

    public void PanelOnClick()
    {
        panel.SetActive(true);
        anim.Play("PanelOff");

    }
    public void PanelOffClick()
    {
        
        anim.Play("PanelOn");
        
        
    }
    public void PanelOffClickWithoutButton()
    {
        
        anim.Play("PanelOffWithoutBTN");
        
        
    }

    public void NoActivePanel()
    {
        panel.SetActive(false);
        backButton.SetActive(false);
        panelButton.SetActive(true);
    }
 
}

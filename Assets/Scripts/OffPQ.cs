using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffPQ : MonoBehaviour
{
    public GameObject pq;
    public GameObject Db;
    public Animator panel;
    public GameObject panel2;

    public void offP(){
        pq.SetActive(false);
        
    }
    public void ssss(){
            Db.SetActive(true);
    }

    public void blackout(){
       panel2.SetActive(true);
        panel.SetTrigger("vkl");
    }
}

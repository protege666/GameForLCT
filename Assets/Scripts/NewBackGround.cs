using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBackGround : MonoBehaviour
{
    public Image NewBackGroundImage;
    public GameObject BlackoutPanel;
    public Animator anim;
    public Sprite[] DistrictImage = new Sprite[8];


    int Number;
    int NumberRegion;

    public void OpenRegionDistrict(int Number)
    {
        NumberRegion = Number;
    }

    public void SetImage()
    {
        NewBackGroundImage.sprite = DistrictImage[NumberRegion];
    }

    public void SetAnim()
    {
        anim.SetTrigger("In");
    }

    public void SetBlackoutPanel()
    {
        BlackoutPanel.SetActive(false);
    }
}

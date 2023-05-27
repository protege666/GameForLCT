using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    
    public GameObject DevicePanel;
    public GameObject MapSheet;
    public GameObject PhotoSheet;
    public GameObject BackDeviceBttn;
    public GameObject DeviceBttn;
    
    public GameObject OptionBttn;
    public GameObject OptionMenu;
    public GameObject BackOptionBttn;

    public GameObject PhotoCamera;

    bool sheet_active = true;
    bool option_bool = true;

   

    public void OpenAndCloseSheet()
    {
        if (sheet_active == true) 
        {
            MapSheet.transform.gameObject.SetActive(false);
            PhotoSheet.transform.gameObject.SetActive(true);
            sheet_active = false;
        }
        else
        {
            MapSheet.transform.gameObject.SetActive(true);
            PhotoSheet.transform.gameObject.SetActive(false);
            sheet_active = true;
        }
    }

    public void OpenAndCloseOptionBttn()
    {
        if (option_bool == true)
        {
            OptionMenu.transform.gameObject.SetActive(true);
            BackOptionBttn.transform.gameObject.SetActive(true);
            OptionBttn.transform.gameObject.SetActive(false);
            option_bool = false;
        }
        else
        {
            OptionMenu.transform.gameObject.SetActive(false);
            BackOptionBttn.transform.gameObject.SetActive(false);
            OptionBttn.transform.gameObject.SetActive(true);
            option_bool = true;
        }
    }
}

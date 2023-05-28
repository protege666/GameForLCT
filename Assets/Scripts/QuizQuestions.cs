using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizQuestions : Switch
{
   public GameObject PanelQuestions;
   public GameObject[] District = new GameObject[9];
   public QuestionsList[] questions;
   public Text[] answersText;
   public Text qText;
   public Sprite[] TFIcons = new Sprite[2];
   public Image TFIcon;
   public Text TFText;
   public Button[] answerBttns = new Button[4];
   public Image[] charges = new Image[4];
   public Image PriceImg;
   public Sprite[] ListPriceImg = new Sprite[8];
   public Animator anim;  
   public Animator pqAnimator; 
   public Animator battery;
   
//    public Image newTer;
//    public Button newTerrBtn;

   private int sumcharges = 4;
   List<object> qList;
   QuestionsList curentQ;
//-----------------------------------------
public Animator animBlack;
public GameObject blackPanel;
public GameObject panel;
//----------------------------------------
   int randQ;
   int Number;
   int NumberRegion;

// public void NoCharges()
// {
//      animBlack.Play("PanelOn");
//      panel.SetActive(true);
//      animBlack.Play("PanelOff");
//      blackPanel.SetActive(true);
     
//      animBlack.Play("NoBattery");
// }

     public void OnPlanshet()
     {
          blackPanel.SetActive(true);
          pqAnimator.SetTrigger("GameOver");
         // animBlack.SetTrigger("On");

          
     }

     public void ButtonActive(){
          animBlack.SetTrigger("OnButton");
     }


   private void Awake()
   {
     anim = PhotoCamera.GetComponent<Animator>();
   }  

   public void OnClickPlay()
   {
        qList = new List<object>(questions);
        questionGenerate();
        PanelQuestions.transform.gameObject.SetActive(true);
        BackDeviceBttn.transform.gameObject.SetActive(false);
        DevicePanel.transform.gameObject.SetActive(false);
   }


    public void OpenRegionDistrict(int Number)
    {
          NumberRegion = Number;
          OnClickPlay();

    }


    public void CloseRegionDistrict()
    {
          District[NumberRegion].transform.gameObject.SetActive(false);
          
    } 



   void questionGenerate()
   {
        randQ = Random.Range(0, qList.Count);
        curentQ = qList[randQ] as QuestionsList;
        qText.text = curentQ.question;
        List<string> answers = new List<string>(curentQ.answers);
        for (int i = 0; i < curentQ.answers.Length; i++) 
        {
               int rand = Random.Range(0, answers.Count);
               answersText[i].text = answers[rand];
               answers.RemoveAt(rand);
        }
   }

   public void TrueOrFalse(bool check)
   {
          if (check)
          {
               TFIcon.sprite = TFIcons[0];
               TFText.text = "Правильно. Ты молодец! Делай фотографию.";
               PriceImg.sprite = ListPriceImg[NumberRegion];
               CloseRegionDistrict();
               // newTerrBtn.interactable = true;
               // Color newColor = new Color(255 / 255f, 255 / 255f, 255 / 255f);
               // newTer.color = newColor;
               anim.SetTrigger("Begin");
               ButtonActive();

          }
          else 
          {
               TFIcon.sprite = TFIcons[1];
               TFText.text = "Неправильно. Ну ничего, ты сможешь ответить лучше.";
               if (sumcharges > 0)
               {
               sumcharges --;
               charges[sumcharges].enabled = false;
                    if(sumcharges == 0){
                         OnPlanshet();
                    }
               }
               else{
                    Debug.Log("Энергия закончилась");
               }
          }
   }




   public void answersBttns(int index)
   {
          if (answersText[index].text.ToString() == curentQ.answers[0]) TrueOrFalse(true);
          else TrueOrFalse(false);

   }

     public void PanelQuestionsOut()
     {
          PanelQuestions.transform.gameObject.SetActive(false);
          BackDeviceBttn.transform.gameObject.SetActive(false);
          DevicePanel.transform.gameObject.SetActive(false);
          
          //DeviceBttn.SetActive(true);
     }
}

[System.Serializable]
public class QuestionsList 
{
    public string question;
    public string[] answers = new string[4];
}
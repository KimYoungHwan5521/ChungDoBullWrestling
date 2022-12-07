using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class TitleIntroScripts : MonoBehaviour
{
    // title
    public void OnClickStart()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public GameObject SaveFilesTab;
    public Text[] TextSaveFile;
    public Text[] TextSavedTime;

    public void OnClickLoad()
    {
        for(int i=0;i<3;i++)
        {
            if(File.Exists(DataManager.instance.path + $"{i}"))
            {
                DataManager.instance.nowSlot = i;
                DataManager.instance.LoadData();
                string temp;
                int intDate = DataManager.instance.savedData.intDate;
                if(intDate % 7 == 0) temp = "<color=red>일요일</color>";
                else if(intDate % 7 == 1) temp = "월요일";
                else if(intDate % 7 == 2) temp = "화요일";
                else if(intDate % 7 == 3) temp = "수요일";
                else if(intDate % 7 == 4) temp = "목요일";
                else if(intDate % 7 == 5) temp = "금요일";
                else temp = "<color=blue>토요일</color>";
                TextSaveFile[i].text = (intDate / 7 + 1).ToString() + "주차" + temp;
                TextSavedTime[i].text = DataManager.instance.savedTime;
            }
            else
            {
                TextSaveFile[i].text = "빈 슬롯";
                TextSavedTime[i].text = "";
            }
        }
        SaveFilesTab.SetActive(true);
    }

    public void OnClickCloseSaveFilesTap()
    {
        SaveFilesTab.SetActive(false);
    }

    public void Load(int slotnum)
    {
        SceneManager.LoadScene("IngameScene");
        ButtonsScript.tutorialInt = 12;
        DataManager.instance.nowSlot = slotnum;
        DataManager.instance.LoadData();
        DataManager.instance.IntegrateLoadedData();

    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    // intro
    public Image introImage;
    public Sprite imageSprite1;
    public Sprite imageSprite2;
    public int count = 0;

    public void OnClickIntro(){
        if(count == 0)
        {
            introImage.sprite = imageSprite1;
        }
        else if(count == 1)
        {
            introImage.sprite = imageSprite2;
        }else
        {
            SceneManager.LoadScene("IngameScene");
        }
        count += 1;
    }

    public void OnClickIntroSkip()
    {
        SceneManager.LoadScene("IngameScene");
    }
}

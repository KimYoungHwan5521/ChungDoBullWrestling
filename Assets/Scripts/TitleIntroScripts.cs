using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleIntroScripts : MonoBehaviour
{
    public Image introImage;
    public Sprite imageSprite1;
    public Sprite imageSprite2;
    public int count = 0;

    // title
    public void OnClickStart()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("IntroScene");
    }

    public void OnClickLoad()
    {
        Debug.Log("Load");
    }

    public void OnClickQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    // intro
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

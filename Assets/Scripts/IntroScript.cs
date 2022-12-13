using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public Image introImage;
    public Sprite[] introSprites;
    public int count = 0;

    public void OnClickIntro(){
        if(introSprites.Length < count + 1)
        {
            SceneManager.LoadScene("IngameScene");
            count = 0;
        }
        else
        {
            introImage.sprite = introSprites[count];
        }
        count += 1;
    }

    public void OnClickIntroSkip()
    {
        SceneManager.LoadScene("IngameScene");
        count = 0;
    }
}

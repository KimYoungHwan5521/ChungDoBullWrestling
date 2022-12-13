using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    
    public Image endingImage;
    public Sprite[] endingSprites0, endingSprites1, endingSprites2, endingSprites3, endingSprites4;
    public int count = 0;
    
    public void OnClickEnding(){
        print(DataManager.ending);
        if(DataManager.ending == 0)
        {
            if(endingSprites0.Length < count + 1)
            {
                SceneManager.LoadScene("TitleScene");
                count = 0;
            }
            else
            {
                endingImage.sprite = endingSprites0[count];
            }
        }
        else if(DataManager.ending == 1)
        {
            if(endingSprites1.Length < count + 1)
            {
                SceneManager.LoadScene("TitleScene");
                count = 0;
            }
            else
            {
                endingImage.sprite = endingSprites1[count];
            }
        }
        else if(DataManager.ending == 2)
        {
            if(endingSprites2.Length < count + 1)
            {
                SceneManager.LoadScene("TitleScene");
                count = 0;
            }
            else
            {
                endingImage.sprite = endingSprites2[count];
            }
        }
        else if(DataManager.ending == 3)
        {
            if(endingSprites3.Length < count + 1)
            {
                SceneManager.LoadScene("TitleScene");
                count = 0;
            }
            else
            {
                endingImage.sprite = endingSprites3[count];
            }
        }
        else if(DataManager.ending == 4)
        {
            if(endingSprites4.Length < count + 1)
            {
                SceneManager.LoadScene("TitleScene");
                count = 0;
            }
            else
            {
                endingImage.sprite = endingSprites4[count];
            }
        }
        count += 1;
    }

    public void OnClickEndingSkip()
    {
        SceneManager.LoadScene("TitleScene");
        count = 0;
    }
}

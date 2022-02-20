using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{

    public Image introImage;
    public Sprite imageSprite1;
    public Sprite imageSprite2;
    public int count = 0;

    // title
    public void OnClickStart(){
        Debug.Log("Start");
        SceneManager.LoadScene("IntroScene");
    }

    public void OnClickLoad(){
        Debug.Log("Load");
    }

    public void OnClickQuit(){
        Debug.Log("Quit");
        Application.Quit();
    }

    // intro
    public void OnClickIntro(){
        if(count == 0){
            introImage.sprite = imageSprite1;
        }else if(count == 1){
            introImage.sprite = imageSprite2;
        }else{
            SceneManager.LoadScene("CowshedScene");
            Debug.Log("Cowshed");
        }
        count += 1;
    }

    public void OnClickIntroSkip(){
        SceneManager.LoadScene("CowshedScene");
        Debug.Log("Skip");
    }

    // cowshed
    public GameObject Cow_Status;
    public void OnClickCow(){
        Cow_Status.SetActive(true);
    }

    public void OnClickCowStatusClose(){
        Cow_Status.SetActive(false);
    }

    public GameObject To_Village;
    public void MouseOverToVillage(){
        To_Village.SetActive(true);
    }

    public void MouseExitToVillage(){
        To_Village.SetActive(false);
    }

    public void OnClickToVillage(){
        SceneManager.LoadScene("VillageScene");
    }

    // village
    public void OnClickCowshed(){
        SceneManager.LoadScene("CowshedScene");
    }
    public void OnClickMarket(){
        SceneManager.LoadScene("MarketScene");
    }
    public void OnClickStadium(){
        SceneManager.LoadScene("StadiumScene");
    }

    // market
    public GameObject Food_Market;
    public GameObject Confirm_Purchase;
    public void OnClickFoodVendor(){
        Food_Market.SetActive(true);
    }
    public void OnClickFoodMarketClose(){
        Food_Market.SetActive(false);
    }
    public Text Merchandise_Text;
    public Text Purchase_Text;
    public void OnClickFoodMarchandise(){
        Purchase_Text.text = Merchandise_Text.text + "을(를) 구매 합니까?";
        Confirm_Purchase.SetActive(true);
    }
    public void OnClickConfirmPurchaseConfirm(){
        //
    }
    public void OnClickConfirmPurchaseDeny(){
        Confirm_Purchase.SetActive(false);
    }

    // stadium
    public void OnClickFight(){
        SceneManager.LoadScene("BullFightScene");
    }
}

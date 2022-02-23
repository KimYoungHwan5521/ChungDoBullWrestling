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

    // ingame
    public GameObject Cowshed;
    public GameObject Village;
    public GameObject Market;
    public GameObject Stadium;

    // cowshed
    public GameObject Cow_Status;
    public void OnClickCow(){
        Cow_Status.SetActive(true);
    }

    public void OnClickCowStatusClose(){
        Cow_Status.SetActive(false);
    }

    public GameObject ToVillage;
    public GameObject To_Village;
    public void MouseOverToVillage(){
        To_Village.SetActive(true);
    }

    public void MouseExitToVillage(){
        To_Village.SetActive(false);
    }

    public void OnClickToVillage(){
        // SceneManager.LoadScene("VillageScene");
        Cowshed.SetActive(false);
        Market.SetActive(false);
        Stadium.SetActive(false);
        Village.SetActive(true);
        ToVillage.SetActive(false);

    }

    // village
    public void OnClickCowshed(){
        // SceneManager.LoadScene("CowshedScene");
        Village.SetActive(false);
        Cowshed.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickMarket(){
        // SceneManager.LoadScene("MarketScene");
        Village.SetActive(false);
        Market.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickStadium(){
        // SceneManager.LoadScene("StadiumScene");
        Village.SetActive(false);
        Stadium.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }

    // market

    // stadium
    public void OnClickFight(){
        SceneManager.LoadScene("BullFightScene");
    }

    // Top menu bar
    public GameObject Inventory;
    public void OnClickInventory()
    {
        Inventory.SetActive(true);
    }
    public void OnClickInventoryClose()
    {
        Inventory.SetActive(false);
    }
}

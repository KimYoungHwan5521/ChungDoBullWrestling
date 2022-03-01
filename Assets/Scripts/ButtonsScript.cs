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
            SceneManager.LoadScene("IngameScene");
            Debug.Log("Cowshed");
        }
        count += 1;
    }

    public void OnClickIntroSkip(){
        SceneManager.LoadScene("IngameScene");
        Debug.Log("Skip");
    }

    // ingame
    public GameObject Cowshed;
    public GameObject Village;
    public GameObject Market;
    public GameObject Stadium;
    public GameObject Field;
    public GameObject BullFight;
    public GameObject ImageVS;
    public GameObject TopMenuBar;

    // cowshed
    public GameObject Cow_Status;
    public Text CowName;
    public Text CowMaxHP;
    public Text CowMaxMP;
    public Text CowAtkDmg;
    public Text CowArmor;
    public Text CowHunger;
    public Text CowCleanliness;
    public Text CowCondition;
    public void OnClickCow(){
        Cow_Status.SetActive(true);
        CowName.text = MyCow.cowName;
        CowMaxHP.text = MyCow.maxHP.ToString();
        CowMaxMP.text = MyCow.maxMP.ToString();
        CowAtkDmg.text = MyCow.atkDmg.ToString();
        CowArmor.text = MyCow.armor.ToString();
        if(MyCow.hunger > 70)
        {
            CowHunger.text = "<color=lime>" + MyCow.hunger.ToString() + "</color>";
        }
        else if(MyCow.hunger > 40)
        {
            CowHunger.text = "<color=orange>" + MyCow.hunger.ToString() + "</color>";
        }
        else if(MyCow.hunger > 10)
        {
            CowHunger.text = "<color=red>" + MyCow.hunger.ToString() + "</color>";
        }
        else
        {
            CowHunger.text = "<color=maroon>" + MyCow.hunger.ToString() + "</color>";
        }
        if(MyCow.cleanliness > 70)
        {
            CowCleanliness.text = "<color=lime>" + MyCow.cleanliness.ToString() + "</color>";
        }
        else if(MyCow.cleanliness > 40)
        {
            CowCleanliness.text = "<color=orange>" + MyCow.cleanliness.ToString() + "</color>";
        }
        else if(MyCow.cleanliness > 10)
        {
            CowCleanliness.text = "<color=red>" + MyCow.cleanliness.ToString() + "</color>";
        }
        else
        {
            CowCleanliness.text = "<color=maroon>" + MyCow.condition.ToString() + "</color>";
        }
        if(MyCow.condition > 70)
        {
            CowCondition.text = "<color=lime>" + MyCow.condition.ToString() + "</color>";
        }
        else if(MyCow.condition > 40)
        {
            CowCondition.text = "<color=orange>" + MyCow.condition.ToString() + "</color>";
        }
        else if(MyCow.condition > 10)
        {
            CowCondition.text = "<color=red>" + MyCow.condition.ToString() + "</color>";
        }
        else
        {
            CowCondition.text = "<color=maroon>" + MyCow.condition.ToString() + "</color>";
        }
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
        Cowshed.SetActive(false);
        Market.SetActive(false);
        Stadium.SetActive(false);
        Field.SetActive(false);
        Village.SetActive(true);
        ToVillage.SetActive(false);

    }

    // village
    public void OnClickCowshed()
    {
        Village.SetActive(false);
        Cowshed.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickMarket()
    {
        Village.SetActive(false);
        Market.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickStadium()
    {
        Village.SetActive(false);
        Stadium.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickField()
    {
        Village.SetActive(false);
        Field.SetActive(true);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }

    // market

    // stadium
    public void OnClickFight()
    {
        ToVillage.SetActive(false);
        Stadium.SetActive(false);
        BullFight.SetActive(true);
        ImageVS.SetActive(true);
        TopMenuBar.SetActive(false);
    }

    // field
    public GameObject Farmer;
    public GameObject PlowingSelect;
    public void OnClickFarmer()
    {
        PlowingSelect.SetActive(true);
    }
    public void OnClickPlowingSelectClose()
    {
        PlowingSelect.SetActive(false);
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

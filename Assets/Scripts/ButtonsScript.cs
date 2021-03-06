using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{

    public GameObject Cowshed;
    public GameObject Village;
    public GameObject Market;
    public GameObject Stadium;
    public GameObject Field;
    public GameObject BullFight;
    public GameObject ImageVS;
    public GameObject TopMenuBar;
    public GameObject Alert;
    public Text AlertText;

    public AudioPlayer AudioManager;
    public AudioClip TownTheme;
    public AudioClip BattleTheme;
    public AudioClip CowboyCowTheme;
    public AudioClip ElephantCowTheme;
    public AudioClip JapaneseCowTheme;
    public AudioClip GermanCowTheme;
    public AudioClip BattleTheme2;


    void Start()
    {
        AudioManager.GetComponent<AudioPlayer>().PlayMusic(TownTheme);
    }

    public GameObject HiddenMerchant;
    public static int tutorialInt = 0;
    public GameObject TutorialDialogWindow;
    public Text TutorialDialog;
    public GameObject TutorialVillageHead;
    public GameObject Arrow;
    public Button Cow;
    void Update()
    {
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
        if(ActionScript.intDayOfTheWeek == 5 && ActionScript.intAction % 4 == 2)
        {
            HiddenMerchant.SetActive(true);
        }
        else
        {
            HiddenMerchant.SetActive(false);
        }

        // calender
        if(calenderPage == 1)
        {
            TrunPageLeft.interactable = false;
        }
        else if(calenderPage == 4)
        {
            TrunPageRight.interactable = false;
        }
        else
        {
            TrunPageLeft.interactable = true;
            TrunPageRight.interactable = true;
        }
        for(int i=0;i<4;i++)
        {
            CalenderPages[i].SetActive(calenderPage == i + 1);
        }
        
        // tutorial
        if(tutorialInt < 12)
        {
            ToVillage.SetActive(false);
            RectTransform ArrowRect = Arrow.GetComponentInChildren<RectTransform>();
            Button[] CowStatusButtons = Cow_Status.GetComponentsInChildren<Button>();
            Cow.interactable = false;
            for(int i=0; i < CowStatusButtons.Length; i++)
            {
                CowStatusButtons[i].interactable = false;
            }
            if(Input.anyKeyDown)
            {
                if(tutorialInt == 0)
                {
                    TutorialDialog.text = "???, ?????? ???????????? ????????? ?????? ???????????? ??? ???????????????";
                }
                else if(tutorialInt == 1)
                {
                    Arrow.SetActive(true);
                    TutorialDialog.text = "?????? ???????????? ??????????????? '??????', '??????', '??????' ??? 3??? ????????? ??? ??? ??????";
                    ArrowRect.anchoredPosition = new Vector3(-400, 475, 0);
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 90);
                }
                else if(tutorialInt == 2)
                {
                    TutorialDialog.text = "????????? ???????????? ????????? ????????????, ????????? ????????????, ????????????, ????????????, ??????, ?????? ?????? ??????";
                }
                else if(tutorialInt == 3)
                {
                    TutorialDialog.text = "?????? ???????????? ?????? ????????? ????????? ??? ??????";
                    ArrowRect.anchoredPosition = new Vector3(-150, -180, 0);
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 0);
                }
                else if(tutorialInt == 4)
                {
                    TutorialDialog.text = "??? ???????????? ????????? ?????????, ????????? ?????? '??????', '?????????', '?????????'??? ????????? ??? ??????";
                    Cow_Status.SetActive(true);
                    ArrowRect.anchoredPosition = new Vector3(-840, -270, 0);
                }
                else if(tutorialInt== 5)
                {
                    TutorialDialog.text = "'??????'??? ??? ????????? 5??? ???????????? 70????????? ?????? ?????? ?????? ??? ???????????? ??????????????? ??????";
                }
                else if(tutorialInt== 6)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -370, 0);
                    TutorialDialog.text = "'?????????'??? ?????? ?????? 10??? ???????????? 70????????? ?????? ????????? ?????? ???????????? ??????????????? ??????";
                }
                else if(tutorialInt== 7)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -470, 0);
                    TutorialDialog.text = "'?????????'??? ????????? ??????????????? ????????? ??? ??????, ???????????? ???????????? ??????????????? ????????? ?????????";
                }
                else if(tutorialInt== 8)
                {
                    TutorialDialog.text = "'?????????'??? 0????????? ?????? ???????????? ????????? ????????????, ???????????? 50 ????????? ?????? ????????? ????????? ?????? ???????????? ???????????? ?????? ??? ??????";
                }
                else if(tutorialInt== 9)
                {
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 90);
                    ArrowRect.anchoredPosition = new Vector3(530, 470, 0);
                    TutorialDialog.text = "'??????', '?????????', '?????????'??? ??? ????????? ????????? ????????? ??? ??????";
                }
                else if(tutorialInt== 10)
                {
                    Arrow.SetActive(false);
                    TutorialDialog.text = "????????? ?????? ????????? ????????????, ????????? ?????? ????????????, ?????? ????????? ??????????????? ???????????? ????????? ?????? ?????? ?????? ?????? ????????? ?????? ????????? ?????? ?????????";
                }
                else
                {
                    Cow.interactable = true;
                    for(int i=0; i < CowStatusButtons.Length; i++)
                    {
                        CowStatusButtons[i].interactable = true;
                    }
                    TutorialVillageHead.SetActive(false);
                    Cow_Status.SetActive(false);
                    TutorialDialogWindow.SetActive(false);
                    ToVillage.SetActive(true);
                }
                tutorialInt++;
            }
        }

    }
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
    public void OnClickCow()
    {
        Cow_Status.SetActive(true);
        ToVillage.SetActive(false);
    }
    public GameObject FoodSelect;
    public void OnClickCowStatusClose()
    {
        Cow_Status.SetActive(false);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
        EquipmentSetting.SetActive(false);
        EquipmentSelect.SetActive(false);
        FoodSelect.SetActive(false);
    }

    public GameObject EquipmentSetting;
    public GameObject EquipmentSelect;
    public GameObject[] EquipmentSlot, IsEquiped;
    public Image EquipedItemHeadImage, EquipedItemBodyImage, EquipedItemLegsImage;

    public void OnClickEquipmentSetting()
    {
        List<Player.Item> equipedItemsHead = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
        List<Player.Item> equipedItemsBody = Player.inventory.FindAll(x => x.itemType == "??????(???)");
        List<Player.Item> equipedItemsLegs = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
        if(equipedItemsHead != null)
        {
            Player.Item equipedItemHead = equipedItemsHead.Find(x => x.isEquiped == true);
            if(equipedItemHead != null)
            {
                EquipmentNameHead.text = equipedItemHead.itemName;
                EquipedItemHeadImage.sprite = equipedItemHead.itemSprite;
                UnEquipHead.SetActive(true);
            }
            else
            {
                EquipmentNameHead.text = "??????";
                EquipedItemHeadImage.sprite = null;
                UnEquipHead.SetActive(false);
            }
        }
        if(equipedItemsBody != null)
        {
            Player.Item equipedItemBody = equipedItemsBody.Find(x => x.isEquiped == true);
            if(equipedItemBody != null)
            {
                EquipmentNameBody.text = equipedItemBody.itemName;
                EquipedItemBodyImage.sprite = equipedItemBody.itemSprite;
                UnEquipBody.SetActive(true);
            }
            else
            {
                EquipmentNameBody.text = "??????";
                EquipedItemBodyImage.sprite = null;
                UnEquipBody.SetActive(false);
            }
        }
        if(equipedItemsLegs != null)
        {
            Player.Item equipedItemLegs = equipedItemsLegs.Find(x => x.isEquiped == true);
            if(equipedItemLegs != null)
            {
                EquipmentNameLegs.text = equipedItemLegs.itemName;
                EquipedItemLegsImage.sprite = equipedItemLegs.itemSprite;
                UnEquipLegs.SetActive(true);
            }
            else
            {
                EquipmentNameLegs.text = "??????";
                EquipedItemLegsImage.sprite = null;
                UnEquipLegs.SetActive(false);
            }
        }
        EquipmentSetting.SetActive(true);
    }
    public void OnClickEquipmentSettingClose()
    {
        EquipmentSetting.SetActive(false);
    }
    public void OnClickEquipmentSettingHead()
    {
        EquipmentSelect.SetActive(true);
        int count = 0;
        for(int i=0; i<Player.inventory.Count; i++)
        {
            if(Player.inventory[i].itemType == "??????(??????)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "????????? ?????? ??? ??? ?????? ????????? ????????????. ???????????? ??????????????????!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "??????(??????)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
                    itemImage.sprite = i < Player.inventory.Count ? Player.inventory[i].itemSprite : null;
                    IsEquiped[i].SetActive(Player.inventory[i].isEquiped);  
                }
                else
                {
                    EquipmentSlot[i].SetActive(false);
                }
            }
            else
            {
                EquipmentSlot[i].SetActive(false);
            }
        }
    }
    public void OnClickEquipmentSettingBody()
    {
        EquipmentSelect.SetActive(true);
        int count = 0;
        for(int i=0; i<Player.inventory.Count; i++)
        {
            if(Player.inventory[i].itemType == "??????(???)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "?????? ?????? ??? ??? ?????? ????????? ????????????. ???????????? ??????????????????!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "??????(???)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
                    itemImage.sprite = i < Player.inventory.Count ? Player.inventory[i].itemSprite : null;
                    IsEquiped[i].SetActive(Player.inventory[i].isEquiped);  
                }
                else
                {
                    EquipmentSlot[i].SetActive(false);
                }
            }
            else
            {
                EquipmentSlot[i].SetActive(false);
            }
        }
    }
    public void OnClickEquipmentSettingLegs()
    {
        EquipmentSelect.SetActive(true);
        int count = 0;
        for(int i=0; i<Player.inventory.Count; i++)
        {
            if(Player.inventory[i].itemType == "??????(??????)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "????????? ?????? ??? ??? ?????? ????????? ????????????. ???????????? ??????????????????!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "??????(??????)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
                    itemImage.sprite = i < Player.inventory.Count ? Player.inventory[i].itemSprite : null;
                    IsEquiped[i].SetActive(Player.inventory[i].isEquiped);  
                }
                else
                {
                    EquipmentSlot[i].SetActive(false);
                }
            }
            else
            {
                EquipmentSlot[i].SetActive(false);
            }
        }
    }
    
    public Text EquipmentNameHead;
    public Text EquipmentNameBody;
    public Text EquipmentNameLegs;
    public GameObject UnEquipHead;
    public GameObject UnEquipBody;
    public GameObject UnEquipLegs;
    public void OnClickEquipmentSelect(int equipmentNum)
    {
        if(Player.inventory[equipmentNum].itemType == "??????(??????)")
        {
            EquipmentNameHead.text = Player.inventory[equipmentNum].itemName;
            EquipedItemHeadImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipHead.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
            Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
            if(equipedItem != null)
            {
                equipedItem.isEquiped = false;
                MyCow.Equiped(false, equipedItem.itemName);
            }
        }
        else if(Player.inventory[equipmentNum].itemType == "??????(???)")
        {
            EquipmentNameBody.text = Player.inventory[equipmentNum].itemName;
            EquipedItemBodyImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipBody.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(???)");
            Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
            if(equipedItem != null)
            {
                equipedItem.isEquiped = false;
                MyCow.Equiped(false, equipedItem.itemName);
            }
        }
        else if(Player.inventory[equipmentNum].itemType == "??????(??????)")
        {
            EquipmentNameLegs.text = Player.inventory[equipmentNum].itemName;
            EquipedItemLegsImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipLegs.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
            Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
            if(equipedItem != null)
            {
                equipedItem.isEquiped = false;
                MyCow.Equiped(false, equipedItem.itemName);
            }
        }
        Player.inventory[equipmentNum].isEquiped = true;
        MyCow.Equiped(true, Player.inventory[equipmentNum].itemName);
        EquipmentSelect.SetActive(false);
    }
    public void OnClickUnEquipHead()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameHead.text = "??????";
        UnEquipHead.SetActive(false);
    }
    public void OnClickUnEquipBody()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(???)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameBody.text = "??????";
        UnEquipBody.SetActive(false);
    }
    public void OnClickUnEquipLegs()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "??????(??????)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameLegs.text = "??????";
        UnEquipLegs.SetActive(false);
    }
    public void OnClickEquipmentSelectClose()
    {
        EquipmentSelect.SetActive(false);
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
    public GameObject ConfirmFight;
    public void OnClickFight()
    {
        if(ActionScript.intAction % 4 == 0 && ActionScript.intDayOfTheWeek % 7 == 6)
        {
            ConfirmFight.SetActive(true);
        }
        else
        {
            AlertText.text = "????????? ?????? ????????? ????????????.\n????????? ?????? ????????? ????????? ????????????.";
            Alert.SetActive(true);
        }
    }
    public void OnClickConfirmFightConfirm()
    {
        ConfirmFight.SetActive(false);
        if(EnemyCow.cowName == "???????????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(CowboyCowTheme);
        }
        else if(EnemyCow.cowName == "?????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(ElephantCowTheme);
        }
        else if(EnemyCow.cowName == "?????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(JapaneseCowTheme);
        }
        else if(EnemyCow.cowName == "?????????" || EnemyCow.cowName == "?????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(GermanCowTheme);
        }
        else
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(BattleTheme);
        }
        ToVillage.SetActive(false);
        Stadium.SetActive(false);
        BullFight.SetActive(true);
        ImageVS.SetActive(true);
        TopMenuBar.SetActive(false);
    }
    public void OnClickConfirmFightDeny()
    {
        ConfirmFight.SetActive(false);
    }

    // field
    public GameObject Farmer;
    public GameObject PlowingSelect;
    public void OnClickFarmer()
    {
        PlowingSelect.SetActive(true);
        ToVillage.SetActive(false);
    }
    public void OnClickPlowingSelectClose()
    {
        PlowingSelect.SetActive(false);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }

    // Top menu bar
    public GameObject Inventory;
    public GameObject Calender;
    public GameObject[] CalenderDates, IsTheDateExpired;
    public GameObject Settings;
    public void OnClickInventory()
    {
        Inventory.SetActive(true);
    }
    public void OnClickInventoryClose()
    {
        Inventory.SetActive(false);
    }
    public void OnClickCalender()
    {
        Calender.SetActive(true);
        for(int i=0;i<CalenderDates.Length;i++)
        {
            IsTheDateExpired[i].SetActive(i < ActionScript.intDate);
        }
    }
    public void OnClickCalenderClose()
    {
        Calender.SetActive(false);
    }
    public Button TrunPageLeft;
    public Button TrunPageRight;
    public int calenderPage = 1;
    public GameObject[] CalenderPages;
    public void OnClickCalenderTurnPageLeft()
    {
        calenderPage--;
    }
    public void OnClickCalenderTurnPageRight()
    {
        calenderPage++;
    }
    public void OnClickSettings()
    {
        Settings.SetActive(true);
    }
    public void OnClickSettingsClose()
    {
        Settings.SetActive(false);
    }
}

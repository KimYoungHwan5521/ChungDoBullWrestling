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
                    TutorialDialog.text = "자, 소를 키우기로 했으니 내가 기본적인 건 알려주겠네";
                }
                else if(tutorialInt == 1)
                {
                    Arrow.SetActive(true);
                    TutorialDialog.text = "먼저 하루에는 기본적으로 '아침', '점심', '저녁' 총 3번 행동을 할 수 있네";
                    ArrowRect.anchoredPosition = new Vector3(-400, 475, 0);
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 90);
                }
                else if(tutorialInt == 2)
                {
                    TutorialDialog.text = "행동을 소모하는 행동은 먹이주기, 사육장 청소하기, 빗질하기, 훈련하기, 알바, 경기 등이 있네";
                }
                else if(tutorialInt == 3)
                {
                    TutorialDialog.text = "소를 클릭하면 소의 상태를 확인할 수 있네";
                    ArrowRect.anchoredPosition = new Vector3(-150, -180, 0);
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 0);
                }
                else if(tutorialInt == 4)
                {
                    TutorialDialog.text = "소 상태창은 이렇게 생겼고, 여기서 소의 '허기', '청결도', '컨디션'을 확인할 수 있네";
                    Cow_Status.SetActive(true);
                    ArrowRect.anchoredPosition = new Vector3(-840, -270, 0);
                }
                else if(tutorialInt== 5)
                {
                    TutorialDialog.text = "'허기'는 매 행동후 5씩 닳아지고 70이하가 되면 다음 행동 후 컨디션을 떯어뜨리게 되네";
                }
                else if(tutorialInt== 6)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -370, 0);
                    TutorialDialog.text = "'청결도'는 매일 아침 10씩 닳아지고 70이하가 되면 다음날 아침 컨디션을 떯어뜨리게 되네";
                }
                else if(tutorialInt== 7)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -470, 0);
                    TutorialDialog.text = "'컨디션'은 허기나 청결도로도 떨어질 수 있고, 행동마다 컨디션을 떨어뜨리는 정도가 다르네";
                }
                else if(tutorialInt== 8)
                {
                    TutorialDialog.text = "'컨디션'이 0이되면 소는 하루동안 휴식을 해야하고, 컨디션이 50 미만인 체로 경기를 치르게 되면 제실력을 발휘하지 못할 수 있네";
                }
                else if(tutorialInt== 9)
                {
                    Arrow.transform.localEulerAngles = new Vector3(0, 0, 90);
                    ArrowRect.anchoredPosition = new Vector3(530, 470, 0);
                    TutorialDialog.text = "'허기', '청결도', '컨디션'은 탑 메뉴바 에서도 확인할 수 있네";
                }
                else if(tutorialInt== 10)
                {
                    Arrow.SetActive(false);
                    TutorialDialog.text = "경기는 매주 토요일 아침이네, 마을도 한번 둘러보고, 경기 일정을 잡아둘테니 경기장에 찾아와 내게 말을 걸면 다음 상대에 대한 정보를 알려 주겠네";
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
        List<Player.Item> equipedItemsHead = Player.inventory.FindAll(x => x.itemType == "장비(머리)");
        List<Player.Item> equipedItemsBody = Player.inventory.FindAll(x => x.itemType == "장비(몸)");
        List<Player.Item> equipedItemsLegs = Player.inventory.FindAll(x => x.itemType == "장비(다리)");
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
                EquipmentNameHead.text = "없음";
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
                EquipmentNameBody.text = "없음";
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
                EquipmentNameLegs.text = "없음";
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
            if(Player.inventory[i].itemType == "장비(머리)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "머리에 장착 할 수 있는 장비가 없습니다. 장터에서 구매해보세요!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(머리)")
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
            if(Player.inventory[i].itemType == "장비(몸)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "몸에 장착 할 수 있는 장비가 없습니다. 장터에서 구매해보세요!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(몸)")
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
            if(Player.inventory[i].itemType == "장비(다리)") count++;
        } 
        if(count == 0)
        {
            EquipmentSelect.SetActive(false);
            AlertText.text = "다리에 장착 할 수 있는 장비가 없습니다. 장터에서 구매해보세요!";
            Alert.SetActive(true);
        }
        for(int i=0; i<EquipmentSlot.Length; i++)
        {
            Text[] itemInfo = EquipmentSlot[i].GetComponentsInChildren<Text>();
            Image itemImage = EquipmentSlot[i].GetComponentInChildren<Image>();
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(다리)")
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
        if(Player.inventory[equipmentNum].itemType == "장비(머리)")
        {
            EquipmentNameHead.text = Player.inventory[equipmentNum].itemName;
            EquipedItemHeadImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipHead.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(머리)");
            Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
            if(equipedItem != null)
            {
                equipedItem.isEquiped = false;
                MyCow.Equiped(false, equipedItem.itemName);
            }
        }
        else if(Player.inventory[equipmentNum].itemType == "장비(몸)")
        {
            EquipmentNameBody.text = Player.inventory[equipmentNum].itemName;
            EquipedItemBodyImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipBody.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(몸)");
            Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
            if(equipedItem != null)
            {
                equipedItem.isEquiped = false;
                MyCow.Equiped(false, equipedItem.itemName);
            }
        }
        else if(Player.inventory[equipmentNum].itemType == "장비(다리)")
        {
            EquipmentNameLegs.text = Player.inventory[equipmentNum].itemName;
            EquipedItemLegsImage.sprite = Player.inventory[equipmentNum].itemSprite;
            UnEquipLegs.SetActive(true);
            List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(다리)");
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
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(머리)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameHead.text = "없음";
        UnEquipHead.SetActive(false);
    }
    public void OnClickUnEquipBody()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(몸)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameBody.text = "없음";
        UnEquipBody.SetActive(false);
    }
    public void OnClickUnEquipLegs()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(다리)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameLegs.text = "없음";
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
            AlertText.text = "지금은 경기 시간이 아닙니다.\n경기는 매주 토요일 아침에 있습니다.";
            Alert.SetActive(true);
        }
    }
    public void OnClickConfirmFightConfirm()
    {
        ConfirmFight.SetActive(false);
        if(EnemyCow.cowName == "카우보이소")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(CowboyCowTheme);
        }
        else if(EnemyCow.cowName == "인도소")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(ElephantCowTheme);
        }
        else if(EnemyCow.cowName == "일본소")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(JapaneseCowTheme);
        }
        else if(EnemyCow.cowName == "독일소" || EnemyCow.cowName == "롹커소")
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

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
        _fadeTime = 6f;
    }

    public GameObject HiddenMerchant;
    public static int tutorialInt = 0;
    public GameObject TutorialDialogWindow;
    public Text TutorialDialog;
    public GameObject TutorialVillageHead;
    public GameObject Arrow;
    public Button Cow;
    float time = 0;
    public float _fadeTime = 10f;
    public Image ToVillageSR;
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
            TutorialVillageHead.SetActive(true);
            TutorialDialogWindow.SetActive(true);
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
                    TutorialDialog.text = "'허기'는 매 행동후 5씩 닳아지고 <color=orange>70</color>이하가 되면 다음 행동 후 컨디션을 떯어뜨리게 되네";
                }
                else if(tutorialInt== 6)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -370, 0);
                    TutorialDialog.text = "'청결도'는 매일 아침 10씩 닳아지고 <color=orange>70</color>이하가 되면 다음날 아침 컨디션을 떯어뜨리게 되네";
                }
                else if(tutorialInt== 7)
                {
                    ArrowRect.anchoredPosition = new Vector3(-840, -470, 0);
                    TutorialDialog.text = "'컨디션'은 허기나 청결도로도 떨어질 수 있고, 행동마다 컨디션을 떨어뜨리는 정도가 다르네";
                }
                else if(tutorialInt== 8)
                {
                    TutorialDialog.text = "'컨디션'이 0이되면 소는 하루동안 휴식을 해야해서 그냥 하루를 날리는 셈이 되지.";
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
                    TutorialDialog.text = "경기는 매주 토요일 아침이네, 마을도 한번 둘러보고, 경기 일정을 잡아둘테니 경기장에 찾아와 내게 말을 걸게, 그때 다음 상대에 대한 정보를 알려 주겠네";
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

        // ToVillage fade effect
        if(time < _fadeTime / 2)
        {
            ToVillageSR.color = new Color(0, 1, 0, 0.05f * (1 - time / (_fadeTime / 2)));
        }
        else if(time < _fadeTime)
        {
            ToVillageSR.color = new Color(0, 1, 0, 0.05f * (2 - _fadeTime / time));
        }
        else
        {
            time = 0;
        }
        time += Time.deltaTime;

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
        EquipedItemHeadImage.sprite = null;
        UnEquipHead.SetActive(false);
    }
    public void OnClickUnEquipBody()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(몸)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameBody.text = "없음";
        EquipedItemBodyImage.sprite = null;
        UnEquipBody.SetActive(false);
    }
    public void OnClickUnEquipLegs()
    {
        List<Player.Item> equipedItems = Player.inventory.FindAll(x => x.itemType == "장비(다리)");
        Player.Item equipedItem = equipedItems.Find(x => x.isEquiped == true);
        equipedItem.isEquiped = false;
        MyCow.Equiped(false, equipedItem.itemName);
        EquipmentNameLegs.text = "없음";
        EquipedItemLegsImage.sprite = null;
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
    public Button ButtonFightStart;
    public Button ButtonVillageHead;
    public Button ButtonSave;
    public Button ButtonLoad;
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
        else if(EnemyCow.cowName == "마법'소'녀")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(JapaneseCowTheme);
        }
        else if(EnemyCow.cowName == "독일소" || EnemyCow.cowName == "롹커소")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(GermanCowTheme);
        }
        else if(EnemyCow.cowName == "우주소" || EnemyCow.cowName == "초사이언소" || EnemyCow.cowName == "건담소" || EnemyCow.cowName == "소 아님")
        {
            AudioManager.GetComponent<AudioPlayer>().PlayMusic(BattleTheme2);
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
        ButtonSave.interactable = false;
        ButtonLoad.interactable = false;
    }
    public void OnClickConfirmFightDeny()
    {
        ConfirmFight.SetActive(false);
    }
    public int dialogIndex;
    public void OnClickVillageHead()
    {
        dialogIndex = 0;
        ButtonFightStart.interactable = false;
        ButtonVillageHead.interactable = false;
        TutorialDialogWindow.SetActive(true);
        ToVillage.SetActive(false);
        if(EnemyCow.cowName == "젖소")
        {
            TutorialDialog.text = "다음 상대는 옆집 이씨네 젖소네";
        }
        else if(EnemyCow.cowName == "누렁이")
        {
            TutorialDialog.text = "다음 상대는 옆마을 정씨네 누렁이네";
        }
        else if(EnemyCow.cowName == "우건마")
        {
            TutorialDialog.text = "다음 상대는 아랫마을 최씨네 소일세";
        }
        else if(EnemyCow.cowName == "불판에서 뛰쳐나온 소")
        {
            TutorialDialog.text = "다음 상대는 옆마을에서 구워 먹으려다가 불판에서 뛰쳐 나온 소라고 하네";
        }
        else if(EnemyCow.cowName == "미친소")
        {
            TutorialDialog.text = "다음 상대는 미친소네";
        }
        else if(EnemyCow.cowName == "롹커소")
        {
            TutorialDialog.text = "다음 상대는 롹커소네";
        }
        else if(EnemyCow.cowName == "시소")
        {
            TutorialDialog.text = "다음 상대는 시소네";
        }
        else if(EnemyCow.cowName == "조소")
        {
            TutorialDialog.text = "다음 상대는 조소네";
        }
        else if(EnemyCow.cowName == "카우보이소")
        {
            TutorialDialog.text = "다음 상대는 미국 출신의 카우보이 소네";
        }
        else if(EnemyCow.cowName == "인도소")
        {
            TutorialDialog.text = "다음 상대는 인도출신의 소네";
        }
        else if(EnemyCow.cowName == "마법'소'녀")
        {
            TutorialDialog.text = "다음 상대는 일본 출신의 소네";
        }
        else if(EnemyCow.cowName == "독일소")
        {
            TutorialDialog.text = "다음 상대는 독일 출신의 소네";
        }
        else
        {
            TutorialDialog.text = "다음 소는 내가 정보가 전혀 없네";
            dialogIndex += 10;
        }

    }
    public void OnClickDialogNext()
    {
        dialogIndex++;
        if(dialogIndex > 10)
        {
            ButtonFightStart.interactable = true;
            ButtonVillageHead.interactable = true;
            TutorialDialogWindow.SetActive(false);
            ToVillage.SetActive(true);
            To_Village.SetActive(false);
            dialogIndex = 0;
        }
        if(EnemyCow.cowName == "젖소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "초반에 힘빼지 말고 녀석이 지쳤을 때에 몰아치는게 좋아보이네";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "누렁이")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "거름을 걷어차서 눈이 안보이게 한다고 하네";
            }
            else if(dialogIndex == 2)
            {
                TutorialDialog.text = "눈이 안보이면 공격을 맞출수가 없으니까 눈부터 씻는게 좋을걸세";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "우건마")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "무시무시한 컴보 공격을 사용한다고 하더구만";
            }
            else if(dialogIndex == 2)
            {
                TutorialDialog.text = "눈이라도 멀게하지 않으면 힘든 상대가 될걸세";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "불판에서 뛰쳐나온 소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "덕분에 화속성 마법을 쓰게 된것 같더구먼";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "미친소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "아주 싸움꾼이라 몸이 튼튼해서 물리공격은 잘 안통하는것 같더구먼";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "롹커소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "특별한 점은 없어보이네";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "시소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "시소 위에만 살아서 균형을 잘잡아 물리공격을 흘리는듯 하네\n태극권 처럼 말이야";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "조소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "흠.. 나무로 깎아서 불에 잘붙을거 같아 보이는구만";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "카우보이소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "세계대회부터는 내가 정보가 많이 없어서 도움이 못되겠구만..";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "인도소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "이야 인도는 소가 참 어마어마하게 크더구만!\n깜짝 놀랄걸세";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "마법'소'녀")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "소가 아주 귀엽더구만";
                dialogIndex += 10;
            }
        }
        else if(EnemyCow.cowName == "독일소")
        {
            if(dialogIndex == 1)
            {
                TutorialDialog.text = "독일산이라고 써있었어";
                dialogIndex += 10;
            }
        }
        else
        {
            if(dialogIndex == 0)
            {
                TutorialDialog.text = "다음 소는 내가 정보가 전혀 없네";
                dialogIndex += 10;
            }
        }
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
    public GameObject OpenSaveFilesTab;
    public GameObject SaveFilesTab;
    bool[] savefilechecks = new bool[3];
    public Button[] ButtonSaveFile;
    public Button ButtonSaveFilesClose;
    public Text[] TextSaveFile;
    public Text[] TextSavedTime;
    public bool saveorload = true;
    public Text TextIsItSave;
    public GameObject ConfirmSave;
    public Text ConfirmSaveText;
    public void OnClickOpenSaveFilesTab(bool SaveOrLoad) // false = save, true = load
    {
        saveorload = SaveOrLoad;
        if(saveorload)
        {
            TextIsItSave.text = "불러오기";
        }
        else
        {
            TextIsItSave.text = "저장하기";
        }
        for(int i=0;i<3;i++)
        {
            if(File.Exists(DataManager.instance.path + $"{i}"))
            {
                savefilechecks[i] = true;
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
    public void SaveSlot(int slotnum)
    {
        DataManager.instance.nowSlot = slotnum;
        if(saveorload)
        {
            if(savefilechecks[slotnum])
            {
                for(int i=0; i<3; i++)
                {
                    ButtonSaveFile[i].interactable = false;
                }
                ButtonSaveFilesClose.interactable = false;
                ConfirmSaveText.text = (slotnum + 1).ToString() + "번 슬롯의 데이터를 로드 합니까?";
                ConfirmSave.SetActive(true);
            }
        }
        else
        {
            if(savefilechecks[slotnum])
            {
                for(int i=0; i<3; i++)
                {
                    ButtonSaveFile[i].interactable = false;
                }
                ButtonSaveFilesClose.interactable = false;
                ConfirmSaveText.text = (slotnum + 1).ToString() + "번 슬롯에 저장데이터가 있습니다. 덮어쓰겠습니까?";
                ConfirmSave.SetActive(true);
            }
            else
            {
                DataManager.instance.SaveData();
                for(int i=0;i<3;i++)
                {
                    if(File.Exists(DataManager.instance.path + $"{i}"))
                    {
                        savefilechecks[i] = true;
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
                for(int i=0; i<3; i++)
                {
                    ButtonSaveFile[i].interactable = true;
                }
                ButtonSaveFilesClose.interactable = true;
                ConfirmSave.SetActive(false);
            }
        }
    }
    public void ConfirmSaveOK()
    {
        for(int i=0; i<3; i++)
        {
            ButtonSaveFile[i].interactable = true;
        }
        ButtonSaveFilesClose.interactable = true;
        if(saveorload)
        {
            DataManager.instance.LoadData();
            DataManager.instance.IntegrateLoadedData();
            for(int i=0; i<3; i++)
            {
                ButtonSaveFile[i].interactable = true;
            }
            ButtonSaveFilesClose.interactable = true;
            ConfirmSave.SetActive(false);
            SaveFilesTab.SetActive(false);
            Settings.SetActive(false);
        }
        else
        {
            DataManager.instance.SaveData();
            for(int i=0;i<3;i++)
            {
                if(File.Exists(DataManager.instance.path + $"{i}"))
                {
                    savefilechecks[i] = true;
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
            for(int i=0; i<3; i++)
            {
                ButtonSaveFile[i].interactable = true;
            }
            ButtonSaveFilesClose.interactable = true;
            ConfirmSave.SetActive(false);
        }
    }
    public void ConfirmSaveDeny()
    {
        for(int i=0; i<3; i++)
        {
            ButtonSaveFile[i].interactable = true;
        }
        ButtonSaveFilesClose.interactable = true;
        ConfirmSave.SetActive(false);
    }
}

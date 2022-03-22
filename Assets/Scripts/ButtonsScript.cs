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
        if(ActionScript.intDayOfTheWeek == 5 && ActionScript.intAction % 3 == 2)
        {
            HiddenMerchant.SetActive(true);
        }
        else
        {
            HiddenMerchant.SetActive(false);
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

    public void OnClickCowStatusClose()
    {
        Cow_Status.SetActive(false);
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }

    public GameObject EquipmentSetting;
    public GameObject EquipmentSelect;
    public GameObject[] EquipmentSlot, IsEquiped;

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
                    UnEquipHead.SetActive(true);
                }
                else
                {
                    EquipmentNameHead.text = "없음";
                    UnEquipHead.SetActive(false);
                }
            }
            if(equipedItemsBody != null)
            {
                Player.Item equipedItemBody = equipedItemsBody.Find(x => x.isEquiped == true);
                if(equipedItemBody != null)
                {
                    EquipmentNameBody.text = equipedItemBody.itemName;
                    UnEquipBody.SetActive(true);
                }
                else
                {
                    EquipmentNameBody.text = "없음";
                    UnEquipBody.SetActive(false);
                }
            }
            if(equipedItemsLegs != null)
            {
                Player.Item equipedItemLegs = equipedItemsLegs.Find(x => x.isEquiped == true);
                if(equipedItemLegs != null)
                {
                    EquipmentNameLegs.text = equipedItemLegs.itemName;
                    UnEquipLegs.SetActive(true);
                }
                else
                {
                    EquipmentNameLegs.text = "없음";
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
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(머리)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
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
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(몸)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
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
            if(i<Player.inventory.Count)
            {
                if(Player.inventory[i].itemType == "장비(다리)")
                {
                    EquipmentSlot[i].SetActive(true);
                    itemInfo[0].text = Player.inventory[i].itemName;
                    itemInfo[1].text = Player.inventory[i].count.ToString();
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
    public void OnClickFight()
    {
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
    public void OnClickSettings()
    {
        Settings.SetActive(true);
    }
    public void OnClickSettingsClose()
    {
        Settings.SetActive(false);
    }
}

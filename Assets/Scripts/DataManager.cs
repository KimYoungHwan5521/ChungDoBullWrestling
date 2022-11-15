using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public SavedData savedData = new SavedData();
    public string path;
    public int nowSlot;
    public string savedTime;
    public List<Player.Item> inventory = new List<Player.Item>();
    public string savedItems;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        // persistentDataPath -> C:\Users\[user name]\AppData\LocalLow\[company name]\[product name]
        path = Application.persistentDataPath + "/SAVE";

    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + nowSlot.ToString());
        savedTime = File.GetLastWriteTime(path + nowSlot.ToString()).ToString("저장시간 : yyyy/MM/dd tt HH:mm:ss");
        savedData = JsonUtility.FromJson<SavedData>(data);
    }

    public void IntegrateLoadedData()
    {
        // 플레이어
        Player.gold = savedData.gold;
        Player.inventory = savedData.inventory.ToList();
        // 소
        MyCow.cowName = savedData.cowName;
        MyCow.maxHP = savedData.maxHP;
        MyCow.maxMP = savedData.maxMP;
        MyCow.atkDmg = savedData.atkDmg;
        MyCow.armor = savedData.armor;
        MyCow.hunger = savedData.hunger;
        MyCow.cleanliness = savedData.cleanliness;
        MyCow.condition = savedData.condition;
        // 게임진행도
        BullFightScript.MilkCowClear = savedData.MilkCowClear;
        BullFightScript.YelloCowClear = savedData.YelloCowClear;
        BullFightScript.KangKeonCowClear = savedData.KangKeonCowClear;
        BullFightScript.BurningCowClear = savedData.BurningCowClear;
        BullFightScript.MadCowClear = savedData.MadCowClear;
        BullFightScript.RockerCowClear = savedData.RockerCowClear;
        BullFightScript.SeesawCowClear = savedData.SeesawCowClear;
        BullFightScript.WoodCowClear = savedData.WoodCowClear;
        BullFightScript.CowboyCowClear = savedData.CowboyCowClear;
        BullFightScript.ElephantCowClear = savedData.ElephantCowClear;
        BullFightScript.JapaneseCowClear = savedData.JapaneseCowClear;
        BullFightScript.GermanCowClear = savedData.GermanCowClear;
        BullFightScript.GalaxyCowClear = savedData.GalaxyCowClear;
        BullFightScript.SuperSaiyanCowClear = savedData.SuperSaiyanCowClear;
        BullFightScript.GunDamCowClear = savedData.GunDamCowClear;
        BullFightScript.NotCowClear = savedData.NotCowClear;

        ActionScript.intAction = savedData.intAction;
        ActionScript.intDayOfTheWeek = savedData.intDayOfTheWeek;
        ActionScript.intDate = savedData.intDate;
        ActionScript.randomForHiddenMarket = savedData.randomForHiddenMarket;
        ActionScript.debtRepaymentEventCheck = savedData.debtRepaymentEventCheck;
        ActionScript.hairbrushPerformance = savedData.hairbrushPerformance;

    }

    public void SaveData()
    {
        savedData = new SavedData();
        for(int i=0;i<Player.inventory.Count;i++)
        {
            savedData.inventory.Add(Player.inventory[i]);
        }
        string data = JsonUtility.ToJson(savedData);
        File.WriteAllText(path + nowSlot.ToString(), data);
    }

    [System.Serializable]
    public class SavedData
    {
        // 플레이어
        public int gold = Player.gold;
        public List<Player.Item> inventory = new List<Player.Item>();
        // 소
        public string cowName = MyCow.cowName;
        public int maxHP = MyCow.maxHP;
        public int maxMP = MyCow.maxMP;
        public int atkDmg = MyCow.atkDmg;
        public int armor = MyCow.armor;
        public int hunger = MyCow.hunger;
        public int cleanliness = MyCow.cleanliness;
        public int condition = MyCow.condition;
        // 게임진행도
        public bool MilkCowClear = BullFightScript.MilkCowClear;
        public bool YelloCowClear = BullFightScript.YelloCowClear;
        public bool KangKeonCowClear = BullFightScript.KangKeonCowClear;
        public bool BurningCowClear = BullFightScript.BurningCowClear;
        public bool MadCowClear = BullFightScript.MadCowClear;
        public bool RockerCowClear = BullFightScript.RockerCowClear;
        public bool SeesawCowClear = BullFightScript.SeesawCowClear;
        public bool WoodCowClear = BullFightScript.WoodCowClear;
        public bool CowboyCowClear = BullFightScript.CowboyCowClear;
        public bool ElephantCowClear = BullFightScript.ElephantCowClear;
        public bool JapaneseCowClear = BullFightScript.JapaneseCowClear;
        public bool GermanCowClear = BullFightScript.GermanCowClear;
        public bool GalaxyCowClear = BullFightScript.GalaxyCowClear;
        public bool SuperSaiyanCowClear = BullFightScript.SuperSaiyanCowClear;
        public bool GunDamCowClear = BullFightScript.GunDamCowClear;
        public bool NotCowClear = BullFightScript.NotCowClear;

        public int intAction = ActionScript.intAction;
        public int intDayOfTheWeek = ActionScript.intDayOfTheWeek;
        public int intDate = ActionScript.intDate;
        public int randomForHiddenMarket = ActionScript.randomForHiddenMarket;
        public int debtRepaymentEventCheck = ActionScript.debtRepaymentEventCheck;
        public int hairbrushPerformance = ActionScript.hairbrushPerformance;
    }

}

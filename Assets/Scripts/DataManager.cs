using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public SavedData savedData = new SavedData();
    public string path;
    public int nowSlot;
    public string savedTime;

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

        path = Application.persistentDataPath + "/SAVE";

    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + nowSlot.ToString());
        savedTime = File.GetLastWriteTime(path + nowSlot.ToString()).ToString("저장시간 : yyyy/MM/dd tt HH:mm:ss");
        savedData = JsonUtility.FromJson<SavedData>(data);
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(savedData);
        File.WriteAllText(path + nowSlot.ToString(), data);
    }

    public class SavedData
    {
        // 아이템 세트효과 발동후 저장하고 불러왔을때 유지 되는지 확인해보기

        // 플레이어
        public int gold;
        public class Item
        {
            public string itemName;
            public string itemType;
            public int itemPrice;
            public string itemExplain;
            public Sprite itemSprite;
            public int count = 1;
            public bool isEquiped = false;
        }
        // 소
        public string cowName;
        public int maxHP;
        public int maxMP;
        public int atkDmg;
        public int armor;
        public int hunger;
        public int cleanliness;
        public int condition;
        // 게임진행도
        public bool MilkCowClear;
        public bool YelloCowClear;
        public bool KangKeonCowClear;
        public bool BurningCowClear;
        public bool MadCowClear;
        public bool RockerCowClear;
        public bool SeesawCowClear;
        public bool WoodCowClear;
        public bool CowboyCowClear;
        public bool ElephantCowClear;
        public bool JapaneseCowClear;
        public bool GermanCowClear;
        public bool GalaxyCowClear;
        public bool SuperSaiyanCowClear;
        public bool GunDamCowClear;
        public bool NotCowClear;

        public int intAction;
        public int intDayOfTheWeek;
        public int intDate;
        public int randomForHiddenMarket;
        public int debtRepaymentEventCheck;
        public int hairbrushPerformance;

    }

}

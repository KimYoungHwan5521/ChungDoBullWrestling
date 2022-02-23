using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json;

[System.Serializable]
public class Item
{
    public Item(string _Name, string _Type, string _Price)
    {
        itemName = _Name;
        itemType = _Type;
        itemPrice = _Price;
    }
    public string itemName;
    public string itemType;
    public string itemPrice;
    // public Sprite itemImage;
    // public int count = 1;
}

public class GameManager : MonoBehaviour
{
    public TextAsset ItemDB;
    public List<Item> AllItemList, MyItemList, CurItemList;
    // public Item MyItem;

    // Start is called before the first frame update
    void Start()
    {
        string[] line = ItemDB.text.Substring(0, ItemDB.text.Length).Split('\r');
        for(int i=0;i<line.Length;i++)
        {
            string[] row = line[i].Split('\t');
            if(i == 0)
            {
                AllItemList.Add(new Item(row[0], row[1], row[2]));
            }
            else
            {
                AllItemList.Add(new Item(row[0].Substring(1), row[1], row[2]));
            }
        }
        SetMarketType("FoodMarket");

        // Save();
        // Load();
        
    }

    // void Save()
    // {
    //     string jdata = JsonConvert.SerializeObject(AllItemList);
    //     File.WriteAllText(Application.dataPath + "/Resources/MyItemText.txt", jdata);
    // }

    // void Load()
    // {
    //     string jdata = File.ReadAllText(Application.dataPath + "/Resources/MyItemText.txt");
    //     MyItemList = JsonConvert.DeserializeObject<List<Item>>(jdata);
    // }



    // market system
    public GameObject Food_Market;
    public GameObject Confirm_Purchase;
    public GameObject Alert;
    public Text Alert_Text;
    public GameObject Alert_Confirm;
    public static int slotnum = 0;

    public void OnClickFoodVendor(){
        Food_Market.SetActive(true);
        SetMarketType("FoodMarket");
    }
    public void OnClickFoodMarketClose(){
        Food_Market.SetActive(false);
    }

    public GameObject[] Marchandise;
    // public Text Merchandise_Text;
    public Text Purchase_Text;
    // public Text Merchandise_Price;

    public void SetMarketType(string market)
    {
        if(market == "FoodMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemType == "먹이");
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                // Debug.Log(itemInfo.Length);
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";

            }
        }
    }
    public void OnClickFoodMarchandise(int slotNum)
    {
        slotnum = slotNum;
        Purchase_Text.text = CurItemList[slotNum].itemName + "을(를) 구매 합니까?";
        // merchandiseText = Merchandise_Text.text;
        // string[] spMP = Merchandise_Price.text.Split('냥');
        // price = int.Parse(spMP[0]);
        Confirm_Purchase.SetActive(true);
        
    }
    public void OnClickConfirmPurchaseConfirm(){
        // Debug.Log(price);
        int price = int.Parse(CurItemList[slotnum].itemPrice);
        if(Player.gold < price)
        {
            Alert_Text.text = "소지금이 부족합니다.";
            Alert.SetActive(true);
        }
        else
        {
            Player.gold -= price;
            bool chk = false;
            for(int i=0;i<Player.inventory.Count;i++)
            {
                if(Player.inventory[i].itemName == CurItemList[slotnum].itemName)
                {
                    Player.inventory[i].count++;
                    chk = true;
                    break;
                }
            }
            if(!chk)
            {
                Player.Item item = new Player.Item();
                item.itemName = CurItemList[slotnum].itemName;
                item.itemType = CurItemList[slotnum].itemType;
                item.itemPrice = price;
                Player.inventory.Add(item);
            }
            Alert_Text.text = "성공적으로 구매하였습니다.";
            Alert.SetActive(true);
        }
    }
    public void OnClickConfirmPurchaseDeny(){
        Confirm_Purchase.SetActive(false);
    }
    public void OnClickAlertCinfirm(){
        Alert.SetActive(false);
        Confirm_Purchase.SetActive(false);
    }

}

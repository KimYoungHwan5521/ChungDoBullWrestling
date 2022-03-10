using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json;

[System.Serializable]
public class Item
{
    public Item(string _Name, string _Type, string _Price, string _Explain)
    {
        itemName = _Name;
        itemType = _Type;
        itemPrice = _Price;
        itemExplain = _Explain;
    }
    public string itemName;
    public string itemType;
    public string itemPrice;
    public string itemExplain;
    // public Sprite itemImage;
    // public int count = 1;
}

public class GameManager : MonoBehaviour
{
    public TextAsset ItemDB;
    public List<Item> AllItemList, CurItemList;
    public AudioPlayer AudioManager;
    public AudioClip sellingSound;

    // Start is called before the first frame update
    void Start()
    {
        string[] line = ItemDB.text.Substring(0, ItemDB.text.Length).Split('\r');
        for(int i=0;i<line.Length;i++)
        {
            string[] row = line[i].Split('\t');
            if(i == 0)
            {
                AllItemList.Add(new Item(row[0], row[1], row[2], row[3]));
            }
            else
            {
                AllItemList.Add(new Item(row[0].Substring(1), row[1], row[2], row[3]));
            }
        }
        SetMarketType("FoodMarket");
    }

    // market system
    public GameObject Food_Market;
    public GameObject Confirm_Purchase;
    public Text Purchase_Text;
    public GameObject Alert;
    public Text Alert_Text;
    public static int slotnum = 0;
    public static int marketID = 0;

    public AudioClip sellingAudio;

    public void OnClickFoodVendor(int MarketID){
        marketID = MarketID;
        if(marketID == 1)
        {
            SetMarketType("FoodMarket");
        }
        else if(marketID == 2)
        {
            SetMarketType("TrinketsMarket");
        }
        else if(marketID == 3)
        {
            SetMarketType("Junkman");
        }
        Food_Market.SetActive(true);
    }
    public void OnClickFoodMarketClose(){
        Food_Market.SetActive(false);
    }

    public GameObject[] Marchandise;
    public Text PartTimeJobText;

    public void SetMarketType(string market)
    {
        if(ActionScript.intAction % 3 == 2)
        {
            PartTimeJobText.text = "장터 알바 하기(야간)\n\n돈 +2500냥\n컨디션 -35";
        }
        else
        {
            PartTimeJobText.text = "장터 알바 하기\n\n돈 +500냥";
        }
        if(market == "FoodMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemType == "먹이");
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";

            }
        }
        else if(market == "TrinketsMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemType == "장비(머리)");
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemType == "장비(몸)"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemType == "장비(다리)"));
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";
            }
        }
        else if(market == "Junkman")
        {
            CurItemList = new List<Item>();
            for(int i=0; i<Player.inventory.Count; i++)
            {
                CurItemList.Add(new Item(Player.inventory[i].itemName, Player.inventory[i].itemType, Player.inventory[i].itemPrice.ToString(), Player.inventory[i].itemExplain));
            }
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                if(i < CurItemList.Count)
                {
                    int priceInt = int.Parse(CurItemList[i].itemPrice) / 2;
                    string priceString = priceInt.ToString();
                    itemInfo[1].text = priceString;
                }
                else
                {
                    itemInfo[1].text = "";
                }
            }
        }
        else
        {
            Debug.Log("Wrong market name!");
        }
    }

    public GameObject ItemExplain;
    public RectTransform ItemExplainRect;
    public Text ItemExplainName;
    public Text ItemExplainType;
    public Text ItemExplainExplain;
    public void MouseOverToMarchandise(int slotNum)
    {
        ItemExplainName.text = CurItemList[slotNum].itemName;
        ItemExplainType.text = CurItemList[slotNum].itemType;
        ItemExplainExplain.text = CurItemList[slotNum].itemExplain;

        Vector2 mousePos = Input.mousePosition;
        ItemExplainRect.position = mousePos + new Vector2(ItemExplainRect.rect.width / 2, -ItemExplainRect.rect.height / 2);
        ItemExplain.SetActive(true);
    }
    public void MouseExitToMarchandise()
    {
        ItemExplain.SetActive(false);
    }

    public void OnClickFoodMarchandise(int slotNum)
    {
        slotnum = slotNum;
        if(marketID == 3)
        {
            int priceInt = int.Parse(CurItemList[slotNum].itemPrice) / 2;
            if(CurItemList[slotnum].itemType == "빗")
            {
                Alert_Text.text = "빗은 판매 할 수 없습니다.";
                Alert.SetActive(true);
                return;
            }
            else if(Player.inventory[slotNum].isEquiped == true)
            {
                Purchase_Text.text = "그 아이템은 장착중입니다. 장착을 해제하고" + priceInt + "냥에 판매 하시겠습니까?";
            }
            else
            {
                Purchase_Text.text = CurItemList[slotNum].itemName + "을(를) " + priceInt + "냥에 판매 합니까?";
            }
        }
        else
        {
            Purchase_Text.text = CurItemList[slotNum].itemName + "을(를)" + CurItemList[slotNum].itemPrice + "냥에 구매 합니까?";
        }
        Confirm_Purchase.SetActive(true);
        
    }
    public void OnClickConfirmPurchaseConfirm(){
        if(marketID == 3)
        {
            Player.gold += int.Parse(CurItemList[slotnum].itemPrice) / 2;
            if(Player.inventory[slotnum].count == 1)
            {
                Player.inventory.RemoveAt(slotnum);
                Alert_Text.text = "성공적으로 판매 하였습니다.";
            }
            else
            {
                Player.inventory[slotnum].count--;
                Alert_Text.text = "성공적으로 판매 하였습니다. (" + Player.inventory[slotnum].itemName + " " + Player.inventory[slotnum].count.ToString() + "개 남음)";
            }
            AudioManager.GetComponent<AudioPlayer>().PlaySound(sellingSound);
            SetMarketType("Junkman");
        }
        else
        {
            int price = int.Parse(CurItemList[slotnum].itemPrice);
            if(Player.gold < price)
            {
                Alert_Text.text = "소지금이 부족합니다.";
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
                    item.itemExplain = CurItemList[slotnum].itemExplain;
                    Player.inventory.Add(item);
                }
                Alert_Text.text = "성공적으로 구매하였습니다.";
                AudioManager.GetComponent<AudioPlayer>().PlaySound(sellingSound);
            }
        }
        Alert.SetActive(true);
    }
    public void OnClickConfirmPurchaseDeny()
    {
        Confirm_Purchase.SetActive(false);
    }

    public GameObject HairbrushReinforcement;
    public Text HairbrushNow;
    public Text HairbrushAfter;
    public Text HairbrushReinforcementCost;
    public Text HairbrushReinforcementPerformance;
    public Player.Item hairbrushNow, hairbrushAfter;

    public GameObject ConfirmHairbrushReinforcement;
    public Text ConfirmHairbrushReinforcementText;
    public void OnClickHairbrushReinforcementMerchant()
    {
        hairbrushNow = Player.inventory.Find(x => x.itemType == "빗");
        if(hairbrushNow.itemExplain.Substring(5,1) == "2")
        {
            Alert_Text.text = "이미 빗이 최고레벨 입니다.";
            Alert.SetActive(true);
        }
        else
        {
            hairbrushAfter = new Player.Item();
            int performance = 0;
            if(hairbrushNow.itemExplain.Substring(5,1) == "0")
            {
                hairbrushAfter.itemName = "중고 빗";
                hairbrushAfter.itemType = "빗";
                hairbrushAfter.itemPrice = 2000;
                hairbrushAfter.itemExplain = "빗 LV 1. 중고지만 적당히 빗질이 된다.";
                performance = 25;
            }
            else if(hairbrushNow.itemExplain.Substring(5,1) == "1")
            {
                hairbrushAfter.itemName = "빛나는 빗";
                hairbrushAfter.itemType = "빗";
                hairbrushAfter.itemPrice = 4000;
                hairbrushAfter.itemExplain = "빗 LV 2. 빗겨주기만 해도 기분이 좋아진다.";
                performance = 40;
            }
            HairbrushNow.text = hairbrushNow.itemName;
            HairbrushAfter.text = hairbrushAfter.itemName;
            HairbrushReinforcementCost.text = (hairbrushAfter.itemPrice - hairbrushNow.itemPrice).ToString();
            HairbrushReinforcementPerformance.text = performance.ToString();
            HairbrushReinforcement.SetActive(true);
        }
    }
    public void OnClickHairbrushReinforcementClose()
    {
        HairbrushReinforcement.SetActive(false);
    }
    public void OnClickHairbrushReinforcement()
    {
        ConfirmHairbrushReinforcementText.text = "빗을 " + (hairbrushAfter.itemPrice - hairbrushNow.itemPrice) + "냥에 업그레이드 합니까?";
        ConfirmHairbrushReinforcement.SetActive(true);
    }

    public void OnClickHairbrushReinforcementConfirm()
    {
        if(Player.gold < hairbrushAfter.itemPrice - hairbrushNow.itemPrice)
        {
            Alert_Text.text = "소지금이 부족합니다.";
        }
        else
        {
            Player.gold -= hairbrushAfter.itemPrice - hairbrushNow.itemPrice;
            Player.inventory.Remove(hairbrushNow);
            Player.inventory.Add(hairbrushAfter);
            Alert_Text.text = "성공적으로 강화했습니다.";
        }
        Alert.SetActive(true);
    }
    public void OnClickHairbrushReinforcementDeny()
    {
        ConfirmHairbrushReinforcement.SetActive(false);
    }
    public void OnClickAlertCinfirm(){
        Alert.SetActive(false);
        Confirm_Purchase.SetActive(false);
        ConfirmHairbrushReinforcement.SetActive(false);
        HairbrushReinforcement.SetActive(false);
    }


}

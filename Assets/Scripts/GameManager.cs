using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Newtonsoft.Json;

[System.Serializable]
public class Item
{
    public Item(string _Name, string _Type, string _Price, string _Explain, string _SpriteID)
    {
        itemName = _Name;
        itemType = _Type;
        itemPrice = _Price;
        itemExplain = _Explain;
        itemSpriteID = _SpriteID;
    }
    public string itemName;
    public string itemType;
    public string itemPrice;
    public string itemExplain;
    public string itemSpriteID;
}

public class GameManager : MonoBehaviour
{
    public TextAsset ItemDB;
    public List<Item> AllItemList, CurItemList;
    public AudioPlayer AudioManager;
    public AudioClip sellingSound;

    public Sprite[] ItemSprites;
    // Start is called before the first frame update
    void Start()
    {
        string[] line = ItemDB.text.Substring(0, ItemDB.text.Length).Split('\r');
        for(int i=0;i<line.Length;i++)
        {
            string[] row = line[i].Split('\t');
            if(i == 0)
            {
                AllItemList.Add(new Item(row[0], row[1], row[2], row[3], row[4]));
            }
            else
            {
                AllItemList.Add(new Item(row[0].Substring(1), row[1], row[2], row[3], row[4]));
            }
        }
        SetMarketType("FoodMarket");
    }

    // market system
    public GameObject Food_Market;
    public Button Food_Market_Button;
    public Button Trinkets_Market_Button;
    public Button Junkman_Button;
    public Button Hidden_Market_Button;
    public GameObject Confirm_Purchase;
    public Text Purchase_Text;
    public GameObject Alert;
    public Text Alert_Text;
    public GameObject ToVillage;
    public GameObject To_Village;
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
        else if(marketID == 4)
        {
            SetMarketType("HiddenMarket");
        }
        Food_Market.SetActive(true);
        Food_Market_Button.interactable = false;
        Trinkets_Market_Button.interactable = false;
        Junkman_Button.interactable = false;
        Hidden_Market_Button.interactable = false;
        HairbrushReinforcementButton.interactable = false;
        ToVillage.SetActive(false);
    }
    public void OnClickFoodMarketClose(){
        Food_Market.SetActive(false);
        Food_Market_Button.interactable = true;
        Trinkets_Market_Button.interactable = true;
        Junkman_Button.interactable = true;
        Hidden_Market_Button.interactable = true;
        HairbrushReinforcementButton.interactable = true;
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }

    public GameObject[] Marchandise;
    public Text PartTimeJobText;
    void Update()
    {
        if(ActionScript.intAction % 4 == 2 || ActionScript.intAction % 4 == 3)
        {
            PartTimeJobText.text = "?????? ?????? ??????(??????)\n\n??? +2500???\n????????? -35";
        }
        else
        {
            PartTimeJobText.text = "?????? ?????? ??????\n\n??? +500???";
        }
    }

    public void SetMarketType(string market)
    {
        if(market == "FoodMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemName == "??????");
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "??????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "??????"));
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                Image itemImage = Marchandise[i].GetComponentInChildren<Image>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";
                itemImage.sprite = i < CurItemList.Count ? ItemSprites[int.Parse(CurItemList[i].itemSpriteID)] : null;

            }
        }
        else if(market == "TrinketsMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemName == "??????");
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "??????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????????"));
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                Image itemImage = Marchandise[i].GetComponentInChildren<Image>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";
                itemImage.sprite = i < CurItemList.Count ? ItemSprites[int.Parse(CurItemList[i].itemSpriteID)] : null;
            }
        }
        else if(market == "Junkman")
        {
            CurItemList = new List<Item>();
            for(int i=0; i<Player.inventory.Count; i++)
            {
                CurItemList.Add(new Item(Player.inventory[i].itemName, Player.inventory[i].itemType, Player.inventory[i].itemPrice.ToString(), Player.inventory[i].itemExplain, Player.inventory[i].itemSprite.name.Substring(4)));
            }
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                Image itemImage = Marchandise[i].GetComponentInChildren<Image>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemImage.sprite = i < CurItemList.Count ? ItemSprites[int.Parse(CurItemList[i].itemSpriteID)] : null;
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
        else if(market == "HiddenMarket")
        {
            CurItemList = AllItemList.FindAll(x => x.itemName == "?????????");
            if(ActionScript.randomForHiddenMarket == 0)
            {
                CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "???????????????"));
            }
            else if(ActionScript.randomForHiddenMarket == 1)
            {
                CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "???????????????"));
            }
            else
            {
                CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "???????????????"));
            }
            CurItemList.AddRange(AllItemList.FindAll(x => x.itemName == "?????? ??????"));
            for(int i=0; i<Marchandise.Length; i++)
            {
                Marchandise[i].SetActive(i<CurItemList.Count);
                Text[] itemInfo = Marchandise[i].GetComponentsInChildren<Text>();
                Image itemImage = Marchandise[i].GetComponentInChildren<Image>();
                itemInfo[0].text = i < CurItemList.Count ? CurItemList[i].itemName : "";
                itemInfo[1].text = i < CurItemList.Count ? CurItemList[i].itemPrice : "";
                itemImage.sprite = i < CurItemList.Count ? ItemSprites[int.Parse(CurItemList[i].itemSpriteID)] : null;
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

    public GameObject FoodCount;
    public Text FoodCountText;
    public static int FoodCountInt = 1;
    public void OnClickFoodMarchandise(int slotNum)
    {
        slotnum = slotNum;
        if(marketID == 3)
        {
            int priceInt = int.Parse(CurItemList[slotNum].itemPrice) / 2;
            if(CurItemList[slotnum].itemType == "???")
            {
                Alert_Text.text = "?????? ?????? ??? ??? ????????????.";
                Alert.SetActive(true);
                return;
            }
            else if(Player.inventory[slotNum].isEquiped == true)
            {
                Purchase_Text.text = "??? ???????????? ??????????????????. ????????? ????????????" + priceInt + "?????? ?????? ???????????????????";
            }
            else
            {
                Purchase_Text.text = CurItemList[slotNum].itemName + "???(???) " + priceInt + "?????? ?????? ??????????";
            }
        }
        else
        {
            Purchase_Text.text = CurItemList[slotNum].itemName + "???(???) " + CurItemList[slotNum].itemPrice + "?????? ?????? ??????????";
            FoodCountInt = 1;
            if(CurItemList[slotNum].itemType == "??????" || CurItemList[slotNum].itemType == "??????") 
            {
                FoodCount.SetActive(true);
                FoodCountText.text = "1";
                Purchase_Text.text = CurItemList[slotNum].itemName + " 1?????? " + CurItemList[slotNum].itemPrice + "?????? ?????? ??????????";
            }
        }
        Confirm_Purchase.SetActive(true);
    }
    public void OnClickFoodCountUp()
    {   
        FoodCountInt++;
        FoodCountText.text = FoodCountInt.ToString();
        Purchase_Text.text = CurItemList[slotnum].itemName + " " + FoodCountInt + "?????? " + int.Parse(CurItemList[slotnum].itemPrice) * FoodCountInt + "?????? ?????? ??????????";
    }
    public void OnClickFoodCountDown()
    {
        if(FoodCountInt > 1)
        {
            FoodCountInt--;
            FoodCountText.text = FoodCountInt.ToString();
            Purchase_Text.text = CurItemList[slotnum].itemName + " " + FoodCountInt + "?????? " + int.Parse(CurItemList[slotnum].itemPrice) * FoodCountInt + "?????? ?????? ??????????";
        }
    }
    public void OnClickConfirmPurchaseConfirm(){
        if(marketID == 3)
        {
            Player.gold += int.Parse(CurItemList[slotnum].itemPrice) / 2;
            if(Player.inventory[slotnum].count == 1)
            {
                if(Player.inventory[slotnum].isEquiped) MyCow.Equiped(false, Player.inventory[slotnum].itemName);
                Player.inventory.RemoveAt(slotnum);
                Alert_Text.text = "??????????????? ?????? ???????????????.";
            }
            else
            {
                Player.inventory[slotnum].count--;
                Alert_Text.text = "??????????????? ?????? ???????????????. (" + Player.inventory[slotnum].itemName + " " + Player.inventory[slotnum].count.ToString() + "??? ??????)";
            }
            AudioManager.GetComponent<AudioPlayer>().PlaySound(sellingSound);
            SetMarketType("Junkman");
        }
        else
        {
            int price = int.Parse(CurItemList[slotnum].itemPrice);
            if(Player.gold < price * FoodCountInt)
            {
                Alert_Text.text = "???????????? ???????????????.";
            }
            else
            {
                Player.gold -= price * FoodCountInt;
                bool chk = false;
                bool hay = false;
                if(CurItemList[slotnum].itemName == "?????? ??????") hay = true;
                for(int i=0;i<Player.inventory.Count;i++)
                {
                    if(Player.inventory[i].itemName == CurItemList[slotnum].itemName)
                    {
                        Player.inventory[i].count += FoodCountInt;
                        chk = true;
                        break;
                    }
                    if(hay && Player.inventory[i].itemName == "??????")
                    {
                        Player.inventory[i].count += 5 * FoodCountInt;
                        chk = true;
                        break;
                    }
                }
                if(!chk)
                {
                    Player.Item item = new Player.Item();
                    if(hay)
                    {
                        Item tempHay = AllItemList.Find(x => x.itemName == "??????");
                        item.itemName = tempHay.itemName;
                        item.itemType = tempHay.itemType;
                        item.itemPrice = price;
                        item.itemExplain = tempHay.itemExplain;
                        item.itemSprite = ItemSprites[11];
                        item.count = 5 * FoodCountInt;
                        Player.inventory.Add(item);
                    }
                    else
                    {
                        item.itemName = CurItemList[slotnum].itemName;
                        item.itemType = CurItemList[slotnum].itemType;
                        item.itemPrice = price;
                        item.itemExplain = CurItemList[slotnum].itemExplain;
                        item.itemSprite = ItemSprites[int.Parse(CurItemList[slotnum].itemSpriteID)];
                        item.count = FoodCountInt;
                        Player.inventory.Add(item);
                    }
                }
                Alert_Text.text = "??????????????? ?????????????????????.";
                AudioManager.GetComponent<AudioPlayer>().PlaySound(sellingSound);
            }
        }
        FoodCount.SetActive(false);
        Alert.SetActive(true);
    }
    public void OnClickConfirmPurchaseDeny()
    {
        Confirm_Purchase.SetActive(false);
        FoodCount.SetActive(false);
    }

    public GameObject HairbrushReinforcement;
    public Button HairbrushReinforcementButton;
    public Image HairbrushNowImage;
    public Image HairbrushAfterImage;
    public Text HairbrushNow;
    public Text HairbrushAfter;
    public Text HairbrushReinforcementCost;
    public Text HairbrushReinforcementPerformance;
    public Player.Item hairbrushNow, hairbrushAfter;

    public GameObject ConfirmHairbrushReinforcement;
    public Text ConfirmHairbrushReinforcementText;
    public static int performance = 20;
    public void OnClickHairbrushReinforcementMerchant()
    {
        hairbrushNow = Player.inventory.Find(x => x.itemType == "???");
        if(hairbrushNow.itemExplain.Substring(5,1) == "4")
        {
            Alert_Text.text = "?????? ?????? ???????????? ?????????.";
            Alert.SetActive(true);
        }
        else
        {
            hairbrushAfter = new Player.Item();
            if(hairbrushNow.itemExplain.Substring(5,1) == "0")
            {
                hairbrushAfter.itemName = "?????? ???";
                hairbrushAfter.itemType = "???";
                hairbrushAfter.itemPrice = 1000;
                hairbrushAfter.itemExplain = "??? LV 1. ???????????? ????????? ????????? ??????.";
                hairbrushAfter.itemSprite = ItemSprites[3];
                performance = 20;
            }
            else if(hairbrushNow.itemExplain.Substring(5,1) == "1")
            {
                hairbrushAfter.itemName = "????????? ???";
                hairbrushAfter.itemType = "???";
                hairbrushAfter.itemPrice = 3000;
                hairbrushAfter.itemExplain = "??? LV 2. ??????????????? ?????? ????????? ????????????.";
                hairbrushAfter.itemSprite = ItemSprites[4];
                performance = 25;
            }
            else if(hairbrushNow.itemExplain.Substring(5,1) == "2")
            {
                hairbrushAfter.itemName = "??? ???";
                hairbrushAfter.itemType = "???";
                hairbrushAfter.itemPrice = 6000;
                hairbrushAfter.itemExplain = "??? LV 3. ??? ????????? ???????????? ????????? ???????????? ??????.";
                hairbrushAfter.itemSprite = ItemSprites[5];
                performance = 30;
            }
            else if(hairbrushNow.itemExplain.Substring(5,1) == "3")
            {
                hairbrushAfter.itemName = "??? ???";
                hairbrushAfter.itemType = "???";
                hairbrushAfter.itemPrice = 10000;
                hairbrushAfter.itemExplain = "??? LV 4. ?????? ????????? ?????? ?????????.";
                hairbrushAfter.itemSprite = ItemSprites[6];
                performance = 40;
            }
            HairbrushNowImage.sprite = hairbrushNow.itemSprite;
            HairbrushAfterImage.sprite = hairbrushAfter.itemSprite;
            HairbrushNow.text = hairbrushNow.itemName;
            HairbrushAfter.text = hairbrushAfter.itemName;
            HairbrushReinforcementCost.text = (hairbrushAfter.itemPrice - hairbrushNow.itemPrice).ToString();
            HairbrushReinforcementPerformance.text = performance.ToString();
            HairbrushReinforcement.SetActive(true);
            Food_Market_Button.interactable = false;
            Trinkets_Market_Button.interactable = false;
            Junkman_Button.interactable = false;
            Hidden_Market_Button.interactable = false;
            HairbrushReinforcementButton.interactable = false;
            ToVillage.SetActive(false);
        }
    }
    public void OnClickHairbrushReinforcementClose()
    {
        HairbrushReinforcement.SetActive(false);
        Food_Market_Button.interactable = true;
        Trinkets_Market_Button.interactable = true;
        Junkman_Button.interactable = true;
        Hidden_Market_Button.interactable = true;
        HairbrushReinforcementButton.interactable = true;
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
    }
    public void OnClickHairbrushReinforcement()
    {
        ConfirmHairbrushReinforcementText.text = "?????? " + (hairbrushAfter.itemPrice - hairbrushNow.itemPrice) + "?????? ??????????????? ??????????";
        ConfirmHairbrushReinforcement.SetActive(true);
    }

    public void OnClickHairbrushReinforcementConfirm()
    {
        if(Player.gold < hairbrushAfter.itemPrice - hairbrushNow.itemPrice)
        {
            Alert_Text.text = "???????????? ???????????????.";
        }
        else
        {
            Player.gold -= hairbrushAfter.itemPrice - hairbrushNow.itemPrice;
            Player.inventory.Remove(hairbrushNow);
            Player.inventory.Add(hairbrushAfter);
            ActionScript.hairbrushPerformance = performance;
            Alert_Text.text = "??????????????? ??????????????????.";
            ConfirmHairbrushReinforcement.SetActive(false);
            HairbrushReinforcement.SetActive(false);
            Food_Market_Button.interactable = true;
            Trinkets_Market_Button.interactable = true;
            Junkman_Button.interactable = true;
            Hidden_Market_Button.interactable = true;
            HairbrushReinforcementButton.interactable = true;
            ToVillage.SetActive(true);
            To_Village.SetActive(false);
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
    }


}

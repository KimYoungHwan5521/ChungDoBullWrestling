using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActionScript : MonoBehaviour
{
    public static int intAction = 0;
    public static int intDayOfTheWeek = 0;
    public static int intDate = 0;
    public static int randomForHiddenMarket = 0;

    public GameObject DebtRepaymentEvent;
    public Text DialogMessage;
    public static int debtRepaymentEventCheck = 0;
    public GameObject InventoryToSell;
    public GameObject[] Slot, IsEquiped;
    public Text PlayerGold;
    
    public Text TimeText;
    public int dialogIndex = 0;
    public Text DayOfTheWeekText;
    public int dateCheck = 0;
    public GameObject DateChange;
    public Text DateChangeText;
    public bool gameover_dept = false;

    public GameObject[] Soils;
    void Start()
    {
        dateCheck = 1;
    }
    void Update()
    {
        if(intAction % 4 == 0)
        {
            TimeText.text = "아침";
        }
        else if(intAction % 4 == 1)
        {
            TimeText.text = "점심";
        }
        else if(intAction % 4 == 2)
        {
            TimeText.text = "저녁";
        }
        else if(intAction % 4 == 3)
        {
            TimeText.text = "밤";
        }
        intDate = intAction / 4;
        intDayOfTheWeek = intDate % 7;
        if(intDayOfTheWeek == 0) DayOfTheWeekText.text = "<color=red>Sun</color>";
        else if(intDayOfTheWeek == 1) DayOfTheWeekText.text = "Mon";
        else if(intDayOfTheWeek == 2) DayOfTheWeekText.text = "Tus";
        else if(intDayOfTheWeek == 3) DayOfTheWeekText.text = "Wed";
        else if(intDayOfTheWeek == 4) DayOfTheWeekText.text = "Thu";
        else if(intDayOfTheWeek == 5) DayOfTheWeekText.text = "Fri";
        else DayOfTheWeekText.text = "<color=blue>Sat</color>";

        if(intDayOfTheWeek == 0) randomForHiddenMarket = Random.Range(0,3);

        PlayerGold.text = Player.gold.ToString();

        if(intDate == dateCheck && intDate > 0)
        {
            string dow = "";
            if(intDayOfTheWeek == 0) dow = "일요일";
            else if(intDayOfTheWeek == 1) dow = "월요일";
            else if(intDayOfTheWeek == 2) dow = "화요일";
            else if(intDayOfTheWeek == 3) dow = "수요일";
            else if(intDayOfTheWeek == 4) dow = "목요일";
            else if(intDayOfTheWeek == 5) dow = "금요일";
            else dow = "토요일";
            if(intDate > 3)
            {
                DateChangeText.text = dow + "\n빚 상환까지 <color=red>" + (debtRepaymentEventCheck * 28 + 3 - intDate).ToString() + "</color>일";
            }
            else
            {
                DateChangeText.text = dow;
            }
            DateChange.SetActive(true);
        }

        if(intDate % 28 >= 3 && debtRepaymentEventCheck == intDate / 28)
        {
            DebtRepaymentEvent.SetActive(true);
            if(intDate < 30)
            {
                if(Input.anyKeyDown)
                {
                    if(dialogIndex==0) DialogMessage.text = "매달 첫째 주 수요일은 빚을 상환하는 날입니다.";
                    if(dialogIndex==1) DialogMessage.text = "첫 달은 상환하지 않지만 돌아오는 다섯째 주 수요일에는 상환금 30000원을 마련해야합니다.";
                    if(dialogIndex==2) DialogMessage.text = "그 때까지 알바나 대회 상금을 통해 돈을 마련해두세요!";
                    if(dialogIndex==3)
                    {
                        DebtRepaymentEvent.SetActive(false);
                        debtRepaymentEventCheck++;
                        DialogMessage.text = "";
                        dialogIndex = 0;
                    }
                    dialogIndex++;
                }
            }
            else
            {
                if(Input.anyKeyDown)
                {
                    bool cont = true;
                    if(dialogIndex==0) DialogMessage.text = "빚 상환일이 돌아왔습니다.";
                    if(dialogIndex==1)
                    {
                        cont = false;
                        if(Player.gold >= 30000)
                        {
                            InventoryToSell.SetActive(false);
                            Player.gold -= 30000;
                            DialogMessage.text = "빚을 상환했습니다. 빚쟁이는 돌아갔습니다.";
                            cont = true;
                        }
                        else
                        {
                            int capital = 0;
                            for(int i=0;i<Player.inventory.Count;i++)
                            {
                                if(Player.inventory[i].itemType != "빗")
                                {
                                    capital += Player.inventory[i].itemPrice / 2;
                                }
                            }
                            if(Player.gold + capital < 30000)
                            {
                                DialogMessage.text = "빚 상환금을 갚지 못하였습니다..";
                                gameover_dept = true;
                            }
                            else
                            {
                                DialogMessage.text = "빚 상환금이 모자랍니다. 물건을 팔아 빚 상환금을 마련하세요.";
                                for(int i=0; i<Slot.Length; i++)
                                {
                                    Slot[i].SetActive(i<Player.inventory.Count);
                                    Text[] itemInfo = Slot[i].GetComponentsInChildren<Text>();
                                    Image itemImage = Slot[i].GetComponentInChildren<Image>();
                                    itemInfo[0].text = i < Player.inventory.Count ? Player.inventory[i].itemName : "";
                                    itemImage.sprite = i < Player.inventory.Count ? Player.inventory[i].itemSprite : null;
                                    if(i < Player.inventory.Count)
                                    {
                                        itemInfo[1].text = (Player.inventory[i].itemPrice / 2).ToString();
                                        IsEquiped[i].SetActive(Player.inventory[i].isEquiped); 
                                    }
                                    else
                                    {
                                        itemInfo[1].text = "";
                                    }
                                }
                                InventoryToSell.SetActive(true);
                            }
                        }
                    }
                    if(dialogIndex == 2)
                    {
                        if(gameover_dept)
                        {
                            DataManager.ending = 0;
                            SceneManager.LoadScene("EndingScene");
                        }
                        InventoryToSell.SetActive(false);
                        DebtRepaymentEvent.SetActive(false);
                        debtRepaymentEventCheck++;
                        DialogMessage.text = "";
                        dialogIndex = 0;
                    }
                    if(cont) dialogIndex++;
                }
            }
        }

        if(MyCow.cleanliness <= 70)
        {
            Soils[0].SetActive(true);
        }
        else if(MyCow.cleanliness <= 40)
        {
            Soils[1].SetActive(true);
            Soils[2].SetActive(true);
        }
        else if(MyCow.cleanliness <= 10)
        {
            Soils[3].SetActive(true);
            Soils[4].SetActive(true);
            Soils[5].SetActive(true);
        }
        else
        {
            Soils[0].SetActive(false);
            Soils[1].SetActive(false);
            Soils[2].SetActive(false);
            Soils[3].SetActive(false);
            Soils[4].SetActive(false);
            Soils[5].SetActive(false);
        }
    }

    public void OnClickDateChangeOK()
    {
        dateCheck++;
        DateChange.SetActive(false);
    }
    
    public GameObject SellConfirm;
    public Text SellText;
    public static int slotNumToSell;
    public void OnClickItem(int slotNum)
    {
        slotNumToSell = slotNum;
        int priceInt = Player.inventory[slotNum].itemPrice / 2;
        if(Player.inventory[slotNum].itemType == "빗")
        {
            AlertText.text = "빗은 판매 할 수 없습니다.";
            Alert.SetActive(true);
            return;
        }
        else if(Player.inventory[slotNum].isEquiped == true)
        {
            SellText.text = "그 아이템은 장착중입니다. 장착을 해제하고" + priceInt + "냥에 판매 하시겠습니까?";
        }
        else
        {
            SellText.text = Player.inventory[slotNum].itemName + "을(를) " + priceInt + "냥에 판매 합니까?";
        }
        SellConfirm.SetActive(true);
        
    }
    public void OnClickConfirmSell()
    {
        Player.gold += Player.inventory[slotNumToSell].itemPrice / 2;
        if(Player.inventory[slotNumToSell].count == 1)
        {
            Player.inventory.RemoveAt(slotNumToSell);
            AlertText.text = "성공적으로 판매 하였습니다.";
        }
        else
        {
            Player.inventory[slotNumToSell].count--;
            AlertText.text = "성공적으로 판매 하였습니다. (" + Player.inventory[slotNumToSell].itemName + " " + Player.inventory[slotNumToSell].count.ToString() + "개 남음)";
        }
        SellConfirm.SetActive(false);
    }
    public void OnClickSellDeny()
    {
        SellConfirm.SetActive(false);
    }

    public GameObject CowStatus;
    public GameObject Market;
    public GameObject ConfirmAction;
    public Text ConfirmText;
    public GameObject Alert;
    public Text AlertText;
    public static int ActionID = 0;
    public static int hairbrushPerformance = 15;

    public GameObject FoodSelect;
    public GameObject[] FoodSlot;
    public void OnClickAction(int actionID)
    {
        ActionID = actionID;
        if(intAction % 4 == 0 && intDayOfTheWeek % 7 == 6)
        {
            AlertText.text = "토요일 아침에는 대회 경기에 참가해야합니다!";
            Alert.SetActive(true);
        }
        else
        {
            ConfirmAction.SetActive(true);
            if(ActionID == 0)
            {
                ConfirmAction.SetActive(false);
                FoodSelect.SetActive(true);
                int count = 0;
                for(int i=0; i<Player.inventory.Count; i++)
                {
                    if(Player.inventory[i].itemType == "먹이") count++;
                } 
                if(count == 0)
                {
                    FoodSelect.SetActive(false);
                    AlertText.text = "줄 수 있는 먹이가 없습니다. 장터에서 구매해보세요!";
                    Alert.SetActive(true);
                }
                for(int i=0; i<FoodSlot.Length; i++)
                {
                    Text[] itemInfo = FoodSlot[i].GetComponentsInChildren<Text>();
                    Image itemImage = FoodSlot[i].GetComponentInChildren<Image>();
                    if(i<Player.inventory.Count)
                    {
                        if(Player.inventory[i].itemType == "먹이")
                        {
                            FoodSlot[i].SetActive(true);
                            itemInfo[0].text = Player.inventory[i].itemName;
                            itemInfo[1].text = Player.inventory[i].count.ToString();
                            itemImage.sprite = i < Player.inventory.Count ? Player.inventory[i].itemSprite : null;
                        }
                        else
                        {
                            FoodSlot[i].SetActive(false);
                        }
                    }
                    else
                    {
                        FoodSlot[i].SetActive(false);
                    }
                }
            }
            else if(ActionID == 1)
            {
                ConfirmText.text = "행동을 소모하여 '털 빗겨주기' 행동을 하시겠습니까? (컨디션 +" + hairbrushPerformance + ")";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 2)
            {
                ConfirmText.text = "행동을 소모하여 '사육장 청소하기' 행동을 하시겠습니까? (청결도 +100)";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 301)
            {
                ConfirmText.text = "행동을 소모하여 '훈련하기' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'뿔 다듬기' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 302)
            {
                ConfirmText.text = "행동을 소모하여 '훈련하기' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'오래 달리기' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 303)
            {
                ConfirmText.text = "행동을 소모하여 '훈련하기' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'차력' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 304)
            {
                ConfirmText.text = "행동을 소모하여 '훈련하기' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'미트치기' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 305)
            {
                ConfirmText.text = "행동을 소모하여 '훈련하기' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'철사장' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 401)
            {
                ConfirmText.text = "행동을 소모하여 '밭매기 알바' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'기름진 비옥한 땅' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 402)
            {
                ConfirmText.text = "행동을 소모하여 '밭매기 알바' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'건조한 땅' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 403)
            {
                ConfirmText.text = "행동을 소모하여 '밭매기 알바' 행동을 하시겠습니까?\n";
                ConfirmText.text += "'돌 많은 척박한 땅' 선택됨";
                ConfirmAction.SetActive(true);
            }
            else if(ActionID == 501)
            {
                if(intAction % 4 == 2 || intAction % 4 == 3)
                {
                    ConfirmText.text = "행동을 소모하여 '장터 알바(야간)' 행동을 하시겠습니까?\n(컨디션 -35)";
                }
                else
                {
                    ConfirmText.text = "행동을 소모하여 '장터 알바' 행동을 하시겠습니까?\n";
                }
                ConfirmAction.SetActive(true);
            }

        }
    }
    public void OnClickFoodSelectClose()
    {
        FoodSelect.SetActive(false);
    }
    public static int foodnum;
    public void OnClickFoodSelect(int slotNum)
    {
        foodnum = slotNum;
        ConfirmText.text = "행동을 소모하여 '먹이주기' 행동을 하시겠습니까? (허기 +30)\n";
        ConfirmText.text += "'" + Player.inventory[slotNum].itemName + "' 선택됨";
        ConfirmAction.SetActive(true);
    }
    public Button Food_Market_Button;
    public Button Trinkets_Market_Button;
    public Button Junkman_Button;
    public Button Hidden_Market_Button;
    public Button HairbrushReinforcementButton;
    public GameObject ToVillage;
    public GameObject To_Village;

    public static bool energyDrink = false;
    public void OnClickConfirmActionConfirm()
    {
        ConfirmAction.SetActive(false);
        CowStatus.SetActive(false);
        Market.SetActive(false);
        Food_Market_Button.interactable = true;
        Trinkets_Market_Button.interactable = true;
        Junkman_Button.interactable = true;
        Hidden_Market_Button.interactable = true;
        HairbrushReinforcementButton.interactable = true;
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
        if(ActionID == 0)
        {
            MyCow.hunger += 30;
            if(MyCow.hunger > 100) MyCow.hunger = 100;
            if(Player.inventory[foodnum].itemName == "건초")
            {
                MyCow.maxHP += 100;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "비료")
            {
                MyCow.maxHP += 200;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "고기")
            {
                MyCow.maxHP += 300;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "소고기")
            {
                MyCow.maxHP += 400;
                MyCow.nowHP = MyCow.maxHP;
            }
            FoodSelect.SetActive(false);
            if(Player.inventory[foodnum].count == 1)
            {
                Player.inventory.RemoveAt(foodnum);
            }
            else
            {
                Player.inventory[foodnum].count--;
            }
        }
        else if(ActionID == 1)
        {
            MyCow.condition += hairbrushPerformance;
            if(MyCow.condition > 100) MyCow.condition = 100;
        }
        else if(ActionID == 2)
        {
            MyCow.cleanliness = 100;
        }
        else if(ActionID == 301)
        {
            MyCow.atkDmg += 10;
            TrainingSelect.SetActive(false);
        }
        else if(ActionID == 302)
        {
            MyCow.maxMP += 5;
            MyCow.nowMP = MyCow.maxMP;
            TrainingSelect.SetActive(false);
        }
        else if(ActionID == 303)
        {
            MyCow.armor += 10;
            MyCow.condition -= 5;
            TrainingSelect.SetActive(false);
        }
        else if(ActionID == 304)
        {
            MyCow.atkDmg += 20;
            MyCow.condition -= 15;
            TrainingSelect.SetActive(false);
        }
        else if(ActionID == 305)
        {
            MyCow.armor += 20;
            MyCow.condition -= 20;
            TrainingSelect.SetActive(false);
        }
        else if(ActionID == 401)
        {
            Player.gold += 1000;
            MyCow.condition -= 5;
            if(MyCow.condition < 0) MyCow.condition = 0;
        }
        else if(ActionID == 402)
        {
            Player.gold += 1500;
            MyCow.condition -= 15;
            if(MyCow.condition < 0) MyCow.condition = 0;
        }
        else if(ActionID == 403)
        {
            Player.gold += 2000;
            MyCow.condition -= 30;
            if(MyCow.condition < 0) MyCow.condition = 0;
        }
        else if(ActionID == 501)
        {
            if(intAction % 3 == 2)
            {
                Player.gold += 2500;
                MyCow.condition -= 35;
                if(MyCow.condition < 0) MyCow.condition = 0;
            }
            else
            {
                Player.gold += 500;
            }
        }

        // end action
        intAction += 1;
        if(intAction % 4 == 3 && !energyDrink)
        {
            intAction++;
        }
        if(MyCow.hunger <= 70) MyCow.condition -= 5;
        if(MyCow.hunger <= 40) MyCow.condition -= 5;
        if(MyCow.hunger <= 10) MyCow.condition -= 10;
        MyCow.hunger -= 5;
        if(MyCow.hunger < 0) MyCow.hunger = 0;


        if(intAction % 4 == 0) 
        {
            if(MyCow.cleanliness <= 70) MyCow.condition -= 15;
            if(MyCow.cleanliness <= 40) MyCow.condition -= 15;
            if(MyCow.cleanliness <= 10) MyCow.condition -= 20;
            MyCow.cleanliness -= 10;
            if(MyCow.cleanliness < 0) MyCow.cleanliness = 0;
        }
        if(MyCow.condition < 0) MyCow.condition = 0;

        print("intAction: " + intAction.ToString());
        if(MyCow.condition == 0)
        {
            if(intAction % 28 > 20 && intAction % 28 < 24)
            {
                int energyDrinkInt = energyDrink ? 1 : 0;
                int skipedActions = 24 - (intAction % 28) + energyDrinkInt;
                AlertText.text = MyCow.cowName + "의 컨디션이 0이 되었습니다.\n경기 전까지 휴식합니다.\n(행동 " + skipedActions + " 스킵)";
                Alert.SetActive(true);
                intAction += skipedActions;
                MyCow.condition += skipedActions * 10;
            }
            else if(intAction % 28 == 24)
            {
                AlertText.text = MyCow.cowName + "의 컨디션이 0이 되었습니다.. 하지만 경기에 나가야 하기에 휴식하지 않습니다.";
                Alert.SetActive(true);
            }
            else
            {
                AlertText.text = MyCow.cowName + "의 컨디션이 0이 되었습니다.\n하루동안 휴식합니다.\n(행동 3 스킵)";
                Alert.SetActive(true);
                intAction += 4;
                MyCow.condition = 30;
            }
        }
    }
    public GameObject TrainingSelect;
    public void OnClickTrainingSelect()
    {
        TrainingSelect.SetActive(true);
    }
    public void OnClickTrainingSelectClose()
    {
        TrainingSelect.SetActive(false);
    }
    public void OnClickConfirmActionDeny()
    {
        ConfirmAction.SetActive(false);
    }
}

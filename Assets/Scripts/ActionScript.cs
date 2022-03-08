using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour
{
    public static int intAction = 0;
    public static int intDayOfTheWeek = 0;
    public static int intDate = 0;

    public GameObject DebtRepaymentEvent;
    public Text DialogMessage;
    public int debtRepaymentEventCheck = 0;
    public GameObject InventoryToSell;
    public GameObject[] Slot;
    // Update is called once per frame
    public Text TimeText;
    public int dialogIndex = 0;
    void Update()
    {
        if(intAction % 3 == 0)
        {
            TimeText.text = "아침";
        }
        else if(intAction % 3 == 1)
        {
            TimeText.text = "점심";
        }
        else if(intAction % 3 == 2)
        {
            TimeText.text = "저녁";
        }
        intDate = intAction / 3;
        intDayOfTheWeek = intDate % 7;

        if(intDate % 28 == 3 && debtRepaymentEventCheck == intDate / 28)
        {
            DebtRepaymentEvent.SetActive(true);
            if(intDate == 3)
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
                                // GameOver();
                            }
                            else
                            {
                                DialogMessage.text = "빚 상환금이 모자랍니다. 물건을 팔아 빚 상환금을 마련하세요.";
                                for(int i=0; i<Slot.Length; i++)
                                {
                                    Slot[i].SetActive(i<Player.inventory.Count);
                                    Text[] itemInfo = Slot[i].GetComponentsInChildren<Text>();
                                    itemInfo[0].text = i < Player.inventory.Count ? Player.inventory[i].itemName : "";
                                    if(i < Player.inventory.Count)
                                    {
                                        itemInfo[1].text = (Player.inventory[i].itemPrice / 2).ToString();
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

    public GameObject FoodSelect;
    public GameObject[] FoodSlot;
    public void OnClickAction(int actionID)
    {
        ActionID = actionID;
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
                if(i<Player.inventory.Count)
                {
                    if(Player.inventory[i].itemType == "먹이")
                    {
                        FoodSlot[i].SetActive(true);
                        itemInfo[0].text = Player.inventory[i].itemName;
                        itemInfo[1].text = Player.inventory[i].count.ToString();
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
            ConfirmText.text = "행동을 소모하여 '털 빗겨주기' 행동을 하시겠습니까? (컨디션 +15)";
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
            if(intAction % 3 == 2)
            {
                ConfirmText.text = "행동을 소모하여 '장터 알바(야간)' 행동을 하시겠습니까?\n";
            }
            else
            {
                ConfirmText.text = "행동을 소모하여 '장터 알바' 행동을 하시겠습니까?\n";
            }
            ConfirmAction.SetActive(true);
        }
        else if(ActionID == 502)
        {
            // 장터 야간알바
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
    public void OnClickConfirmActionConfirm()
    {
        ConfirmAction.SetActive(false);
        CowStatus.SetActive(false);
        Market.SetActive(false);
        if(ActionID == 0)
        {
            MyCow.hunger += 30;
            if(MyCow.hunger > 100) MyCow.hunger = 100;
            if(Player.inventory[foodnum].itemName == "건초")
            {
                MyCow.maxHP += 50;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "비료")
            {
                MyCow.maxHP += 100;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "고기")
            {
                MyCow.maxHP += 150;
                MyCow.nowHP = MyCow.maxHP;
            }
            else if(Player.inventory[foodnum].itemName == "소고기")
            {
                MyCow.maxHP += 200;
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
            MyCow.condition += 15;
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
            MyCow.condition -= 15;
            if(MyCow.condition < 0) MyCow.condition = 0;
        }
        else if(ActionID == 402)
        {
            Player.gold += 1500;
            MyCow.condition -= 20;
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
        if(MyCow.hunger <= 70) MyCow.condition -= 5;
        if(MyCow.hunger <= 40) MyCow.condition -= 5;
        if(MyCow.hunger <= 10) MyCow.condition -= 10;
        MyCow.hunger -= 5;
        if(MyCow.hunger < 0) MyCow.hunger = 0;
        if(intAction % 3 == 0) 
        {
            if(MyCow.cleanliness <= 70) MyCow.condition -= 15;
            if(MyCow.cleanliness <= 40) MyCow.condition -= 15;
            if(MyCow.cleanliness <= 10) MyCow.condition -= 20;
            MyCow.cleanliness -= 10;
            if(MyCow.cleanliness < 0) MyCow.cleanliness = 0;
        }
        if(MyCow.condition < 0) MyCow.condition = 0;
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

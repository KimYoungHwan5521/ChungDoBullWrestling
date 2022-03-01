using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour
{
    public static int intAction = 0;
    public static int intDayOfTheWeek = 0;
    public static int intDate = 0;

    // Update is called once per frame
    public Text TimeText;
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
    }

    public GameObject CowStatus;
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
        else if(ActionID == 3)
        {
            // 훈련하기 선택지
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
            ConfirmText.text = "행동을 소모하여 '장터 알바' 행동을 하시겠습니까?\n";
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
        else if(ActionID == 3)
        {
            // 훈련
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
            Player.gold += 500;
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
    public void OnClickConfirmActionDeny()
    {
        ConfirmAction.SetActive(false);
    }
}

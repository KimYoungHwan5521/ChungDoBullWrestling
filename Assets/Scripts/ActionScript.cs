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
    public void OnClickAction(int actionID)
    {
        ActionID = actionID;
        ConfirmAction.SetActive(true);
        if(ActionID == 0)
        {
            ConfirmText.text = "행동을 소모하여 '먹이주기' 행동을 하시겠습니까?";
        }
        else if(ActionID == 1)
        {
            ConfirmText.text = "행동을 소모하여 '털 빗겨주기' 행동을 하시겠습니까?";
        }
        else if(ActionID == 2)
        {
            ConfirmText.text = "행동을 소모하여 '사육장 청소하기' 행동을 하시겠습니까?";
        }
        else if(ActionID == 3)
        {
            // 훈련하기 선택지
        }
    }
    public void OnClickConfirmActionConfirm()
    {
        ConfirmAction.SetActive(false);
        CowStatus.SetActive(false);
        if(ActionID == 0)
        {
            // 먹이주기
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

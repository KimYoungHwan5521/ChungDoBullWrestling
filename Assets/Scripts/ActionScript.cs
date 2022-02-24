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
}

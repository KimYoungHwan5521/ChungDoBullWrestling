using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MyCow : MonoBehaviour
{
    public static string cowName = "소";
    public static int maxHP = 1000;
    public static int nowHP = 1000;
    public static int maxMP = 100;
    public static int nowMP = 100;
    public static int atkDmg = 10;
    public static int armor = 10;
    public Image HPbar;
    public Image MPbar;
    public static int hunger = 100;
    public static int cleanliness = 100;
    public static int condition = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPbar.fillAmount = (float)nowHP / (float)maxHP;
        MPbar.fillAmount = (float)nowMP / (float)maxMP;
    }

    public static void Equiped(bool equiped, string equipmentName)
    {
        if(equipmentName == "은투구")
        {
            if(equiped)
            {
                armor += 50;
            }
            else
            {
                armor -= 50;
            }
        }
        else if(equipmentName == "금투구")
        {
            if(equiped)
            {
                armor += 100;
            }
            else
            {
                armor -= 100;
            }
        }
        else if(equipmentName == "은갑옷")
        {
            if(equiped)
            {
                armor += 50;
            }
            else
            {
                armor -= 50;
            }
        }
        else if(equipmentName == "금갑옷")
        {
            if(equiped)
            {
                armor += 100;
            }
            else
            {
                armor -= 100;
            }
        }
        else if(equipmentName == "운동화")
        {
            if(equiped)
            {
                atkDmg += 50;
            }
            else
            {
                atkDmg -= 50;
            }
        }
        else if(equipmentName == "구두")
        {
            if(equiped)
            {
                atkDmg += 100;
            }
            else
            {
                atkDmg -= 100;
            }
        }
    }
    
}

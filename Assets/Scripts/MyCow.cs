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
    public static int atkDmg = 100;
    public static int armor = 10;
    public Image HPbar;
    public Image MPbar;
    public static int hunger = 100;
    public static int cleanliness = 100;
    public static int condition = 100;
    
    public GameObject Alert1;
    public Text AlertText1;
    public static GameObject Alert;
    public static Text AlertText;

    void Start()
    {
        Alert = Alert1;
        AlertText = AlertText1;
    }

    public Image HungerBar;
    public Text HungerBarText;
    public Image CleanlinessBar;
    public Text CleanlinessBarText;
    public Image ConditionBar;
    public Text ConditionBarText;
    void Update()
    {
        HPbar.fillAmount = (float)nowHP / (float)maxHP;
        MPbar.fillAmount = (float)nowMP / (float)maxMP;
        HungerBar.fillAmount = (float) hunger / 100;
        HungerBarText.text = hunger.ToString() + "/100";
        CleanlinessBar.fillAmount = (float) cleanliness / 100;
        CleanlinessBarText.text = cleanliness.ToString() + "/100";
        ConditionBar.fillAmount = (float) condition / 100;
        ConditionBarText.text = condition.ToString() + "/100";
        if(hunger > 70)
        {
            HungerBar.color = new Color(0, 1, 0);
        }
        else if(hunger > 40)
        {
            HungerBar.color = new Color(1, 1, 0);
        }
        else if(hunger > 10)
        {
            HungerBar.color = new Color(1, 0, 0);
        }
        else
        {
            HungerBar.color = new Color(0.5f, 0, 0);
        }
        if(cleanliness > 70)
        {
            CleanlinessBar.color = new Color(0, 1, 0);
        }
        else if(cleanliness > 40)
        {
            CleanlinessBar.color = new Color(1, 1, 0);
        }
        else if(cleanliness > 10)
        {
            CleanlinessBar.color = new Color(1, 0, 0);
        }
        else
        {
            CleanlinessBar.color = new Color(0.5f, 0, 0);
        }
        if(condition > 70)
        {
            ConditionBar.color = new Color(0, 1, 0);
        }
        else if(condition > 40)
        {
            ConditionBar.color = new Color(1, 1, 0);
        }
        else if(condition > 10)
        {
            ConditionBar.color = new Color(1, 0, 0);
        }
        else
        {
            ConditionBar.color = new Color(0.5f, 0, 0);
        }
    }

    public static Player.Item setCheck1, setCheck2;
    public static void Equiped(bool equiped, string equipmentName)
    {
        if(equipmentName == "은투구")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "은갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "은편자");
            if(equiped)
            {
                armor += 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", true);
                    }
                }
            }
            else
            {
                armor -= 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "금투구")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "금갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "금편자");
            if(equiped)
            {
                armor += 100;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", true);
                    }
                }
            }
            else
            {
                armor -= 100;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "은갑옷")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "은투구");
            setCheck2 = Player.inventory.Find(x => x.itemName == "은편자");
            if(equiped)
            {
                armor += 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", true);
                    }
                }
            }
            else
            {
                armor -= 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "금갑옷")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "금투구");
            setCheck2 = Player.inventory.Find(x => x.itemName == "금편자");
            if(equiped)
            {
                armor += 100;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", true);
                    }
                }
            }
            else
            {
                armor -= 100;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "은편자")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "은갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "은투구");
            if(equiped)
            {
                atkDmg += 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", true);
                    }
                }
            }
            else
            {
                atkDmg -= 50;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("은세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "금편자")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "금갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "금투구");
            if(equiped)
            {
                atkDmg += 100;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", true);
                    }
                }
            }
            else
            {
                atkDmg -= 100;
                setCheck1 = Player.inventory.Find(x => x.itemName == "금갑옷");
                setCheck2 = Player.inventory.Find(x => x.itemName == "금투구");
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("금세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "다이아투구")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "다이아갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "다이아편자");
            if(equiped)
            {
                armor += 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", true);
                    }
                }
            }
            else
            {
                armor -= 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "다이아갑옷")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "다이아투구");
            setCheck2 = Player.inventory.Find(x => x.itemName == "다이아편자");
            if(equiped)
            {
                armor += 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", true);
                    }
                }
            }
            else
            {
                armor -= 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "다이아편자")
        {
            setCheck1 = Player.inventory.Find(x => x.itemName == "다이아갑옷");
            setCheck2 = Player.inventory.Find(x => x.itemName == "다이아투구");
            if(equiped)
            {
                atkDmg += 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", true);
                    }
                }
            }
            else
            {
                atkDmg -= 200;
                if(setCheck1 != null && setCheck2 != null)
                {
                    if(setCheck1.isEquiped && setCheck2.isEquiped)
                    {
                        SetItemSynergy("다이아세트", false);
                    }
                }
            }
        }
        else if(equipmentName == "화관")
        {
            if(equiped)
            {
                atkDmg += 10;
            }
            else
            {
                atkDmg -= 10;
            }
        }
        else if(equipmentName == "운동화")
        {
            if(equiped)
            {
                armor += 10;
            }
            else
            {
                armor -= 10;
            }
        }
        else if(equipmentName == "구두")
        {
            if(equiped)
            {
                atkDmg += 30;
            }
            else
            {
                armor -= 30;
            }
        }
        else
        {
            Debug.Log("Wrong equipmentName!");
        }
    }

    public static void SetItemSynergy(string set, bool onoff)
    {
        if(set == "은세트")
        {
            if(onoff)
            {
                AlertText.text = "은세트 효과 발동 (공격력 +50)";
                Alert.SetActive(true);
                atkDmg += 50;
            }
            else
            {
                atkDmg -= 50;
            }
        }
        else if(set == "금세트")
        {
            if(onoff)
            {
                AlertText.text = "금세트 효과 발동 (공격력 +100)";
                Alert.SetActive(true);
                atkDmg += 100;
            }
            else
            {
                atkDmg -= 100;
            }
        }
        else if(set == "다이아세트")
        {
            if(onoff)
            {
                AlertText.text = "다이아세트 효과 발동 (공격력 +200)";
                Alert.SetActive(true);
                atkDmg += 200;
            }
            else
            {
                atkDmg -= 200;
            }
        }
        else
        {
            Debug.Log("Wrong set name!");
        }
    }
    
}

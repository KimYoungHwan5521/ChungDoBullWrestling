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
    public static int atkDmg = 1000;
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
    
}

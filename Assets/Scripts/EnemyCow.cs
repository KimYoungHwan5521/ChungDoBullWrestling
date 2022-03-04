using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCow : MonoBehaviour
{
    public static string cowName = "젖소";
    public static int maxHP = 1000;
    public static int nowHP = 1000;
    public static int atkDmg = 100;
    public static int armor = 10;
    public Image HPbar;
 
    public static void SetEnemyStatus(string _enemyName, int _maxHp, int _atkDmg, int _armor)
    {
        cowName = _enemyName;
        maxHP = _maxHp;
        nowHP = _maxHp;
        atkDmg = _atkDmg;
        armor = _armor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPbar.fillAmount = (float)nowHP / (float)maxHP;
    }

}

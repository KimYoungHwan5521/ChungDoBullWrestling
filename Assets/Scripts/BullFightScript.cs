using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BullFightScript : MonoBehaviour
{
    // public Text Mouse_Overed_Skill;
    public Text Skill_Name;
    public Text Mana_Required;
    public Text Skill_Explanation;

    // Buffs/Debuffs
    public GameObject cowBlind;
    public GameObject enemyCowBlind;
    public GameObject cowRage;
    public GameObject enemyCowRage;
    public GameObject cowBalanced;
    public GameObject enemyCowBalanced;
    public GameObject cowOnFire;
    public GameObject enemyCowOnFire;
    public GameObject cowImmune;
    public GameObject enemyCowImmune;
    public GameObject cowSealed;
    public GameObject enemyCowSealed;
    public GameObject cowSteelization;
    public GameObject enemyCowSteelization;
    public GameObject cowSuperSaiyan;
    public GameObject enemyCowSuperSaiyan;
    
    // Buff/Debuffs left turns
    public Text cowBlindLeft;
    public Text enemyCowBlindLeft;
    public Text cowRageLeft;
    public Text enemyCowRageLeft;
    public Text cowBalancedLeft;
    public Text enemyCowBalancedLeft;
    public Text cowOnFireLeft;
    public Text enemyCowOnFireLeft;
    public Text cowImmuneLeft;
    public Text enemyCowImmuneLeft;
    public Text cowSealedLeft;
    public Text enemyCowSealedLeft;
    public Text cowSteelizationLeft;
    public Text enemyCowSteelizationLeft;
    public Text cowSuperSaiyanLeft;
    public Text enemyCowSuperSaiyanLeft;

    // Progress
    public static bool MilkCowClear = false;
    public static bool YelloCowClear = false;
    public static bool KangKeonCowClear = false;
    public static bool BurningCowClear = false;
    public static bool MadCowClear = false;
    public static bool RockerCowClear = false;
    public static bool SeesawCowClear = false;
    public static bool WoodCowClear = false;
    public static bool CowboyCowClear = false;
    public static bool JapaneseCowClear = false;
    public static bool ElephantCowClear = false;
    public static bool GermanCowClear = false;
    public static bool SpaceshipRiderCowClear = false;
    public static bool GalaxyCowClear = false;
    public static bool SuperSaiyanCowClear = false;
    public static bool NotCowClear = false;

    public GameObject ImageVS;
    public GameObject Skill3;
    public GameObject Skill4;
    public GameObject Skill5;
    public GameObject Skill6;
    public GameObject Skill7;
    public GameObject Skill8;
    public GameObject Skill9;
    public GameObject Skill10;
    public GameObject Skill11;
    public GameObject Skill12;
    public GameObject Skill13;
    public GameObject Skill14;
    public GameObject Skill15;

    public ScrollRect scroll_rect;
    public void MouseOverToSkill(int skillID){
        Debug.Log(skillID);
        if(skillID == 0)
        {
            Skill_Name.text = "박치기";
            Mana_Required.text = "<color=blue>활력 0</color>";
            Skill_Explanation.text = "머리를 받아 피해를 입힌다.";
        }
        else if(skillID == 1)
        {
            Skill_Name.text = "핵꿀밤";
            Mana_Required.text = "<color=blue>활력 20</color>";
            Skill_Explanation.text = "머리를 쥐어박아 큰 피해를 입힌다.";
        }
        else if(skillID == 2)
        {
            Skill_Name.text = "우유마시기";
            Mana_Required.text = "<color=blue>활력 0</color>";
            Skill_Explanation.text = "우유를 마셔 모든 해로운 상태이상을 회복하고, 체력과 활력을 조금 회복한다.";
        }
        else if(skillID == 3)
        {
            Skill_Name.text = "거름차기";
            Mana_Required.text = "<color=blue>활력 20</color>";
            Skill_Explanation.text = "뒷발로 거름을 발로차 상대의 눈을 멀게한다.";
        }
        else if(skillID == 4)
        {
            Skill_Name.text = "3단컴보";
            Mana_Required.text = "<color=blue>활력 30</color>";
            Skill_Explanation.text = "3단컴보로 3번 공격한다.";
        }
        else if(skillID == 5)
        {
            Skill_Name.text = "불고기";
            Mana_Required.text = "<color=blue>활력 40</color>";
            Skill_Explanation.text = "상대에게 불을질러 방어력을 낮추고 고정피해를 입힌다.";
        }
        else if(skillID == 6)
        {
            Skill_Name.text = "크로이츠펠트 야곱병";
            Mana_Required.text = "<color=blue>활력 30</color>";
            Skill_Explanation.text = "광우병의 일종. 광폭 상태에 돌입한다.";
        }
        else if(skillID == 7)
        {
            Skill_Name.text = "샤우팅";
            Mana_Required.text = "<color=blue>활력 20</color>";
            Skill_Explanation.text = "강력한 샤우팅으로 상대에게 고정피해를 입히고 이로운 상태를 날려버린다.";
        }
        else if(skillID == 8)
        {
            Skill_Name.text = "균형잡기";
            Mana_Required.text = "<color=blue>활력 50</color>";
            Skill_Explanation.text = "균형을 잡아 상대의 스킬을 회피할 수 있는 상태가 된다.";
        }
        else if(skillID == 9)
        {
            Skill_Name.text = "운기조식";
            Mana_Required.text = "<color=blue>활력 0</color>";
            Skill_Explanation.text = "정신을 집중해 모든 상태이상을 제거하고 면역상태가 되고 활력을 회복한다.";
        }
        else if(skillID == 10)
        {
            Skill_Name.text = "총쏘기";
            Mana_Required.text = "<color=blue>활력 50</color>";
            Skill_Explanation.text = "총을 쏜다.";
        }
        else if(skillID == 1000)
        {
            Skill_Name.text = "<color=red>실명</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "눈이 보이지 않아 물리공격을 맞출 수 없게된다.";
        }
        else if(skillID == 1001)
        {
            Skill_Name.text = "<color=blue>광폭</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "공격력과 방어력이 증가한다.";
        }
        else if(skillID == 1002)
        {
            Skill_Name.text = "<color=blue>균형</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "균형을 잡아 물리공격을 피할 수 있다.";
        }
        else if(skillID == 1003)
        {
            Skill_Name.text = "<color=red>불붙음</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "몸에 불이 붙어 지속피해를 입고, 방어력이 낮아진다.";
        }
        else if(skillID == 1004)
        {
            Skill_Name.text = "<color=blue>면역</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "해로운 상태이상에 걸리지 않는다.";
        }
        else if(skillID == 1005)
        {
            Skill_Name.text = "<color=blue>봉인</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "공격력과 방어력이 낮아진다.";
        }
        else if(skillID == 1006)
        {
            Skill_Name.text = "<color=blue>철괴</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "모든 피해를 감소시켜준다.";
        }
        else if(skillID == 1007)
        {
            Skill_Name.text = "<color=blue>초사이언</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "공격력과 방어력이 증가하고, 해로운 상태이상에 걸리지 않는다.";
        }
        else
        {
            Skill_Explanation.text = "(알 수 없음)";
        }
    }

    public bool myTurn;
    public bool turnEnd;
    public Text turnText;
    public int turn;

    // Start is called before the first frame update
    void Start()
    {
        myTurn = true;
    }

    // Update is called once per frame
    public int dialogID = 0;
    public int dialogIndex = 0;
    void Update()
    {
        turnText.text = turn.ToString(); 
        // Dialogs
        if(dialogID == 1)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0)
                {
                    WarningMessage.text = "승리 상금 3000냥을 획득했다!";
                    Player.gold += 3000;
                } 
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '우유마시기'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 2)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 3000냥을 획득했다!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '거름차기'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 3)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 3000냥을 획득했다!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '3단컴보'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 4)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 3000냥을 획득했다!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) 
                {
                    WarningMessage.text = "지역대회 우승 트로피를 획득했다!";
                    Player.Item item = new Player.Item();
                    item.itemName = "지역대회 우승 트로피";
                    item.itemType = "기타";
                    item.itemPrice = 10000;
                    item.itemExplain = "지역대회 우승 트로피";
                    Player.inventory.Add(item);
                }
                if(dialogIndex==2) WarningMessage.text = MyCow.cowName + "은(는) 기술 '불고기'를 배웠다!";
                if(dialogIndex==3)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 5)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 5000냥을 획득했다!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '크로이츠펠트 야곱병'을 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 6)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 5000냥을 획득했다!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '샤우팅'을 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 7)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 5000냥을 획득했다!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '균형잡기'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 8)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 5000냥을 획득했다!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) 
                {
                    WarningMessage.text = "전국대회 우승 트로피를 획득했다!";
                    Player.Item item = new Player.Item();
                    item.itemName = "전국대회 우승 트로피";
                    item.itemType = "기타";
                    item.itemPrice = 14000;
                    item.itemExplain = "전국대회 우승 트로피";
                    Player.inventory.Add(item);
                }
                if(dialogIndex==2) WarningMessage.text = MyCow.cowName + "은(는) 기술 '운기조식'을 배웠다!";
                if(dialogIndex==3)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 9)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 7000냥을 획득했다!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '총쏘기'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 10)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 7000냥을 획득했다!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '봉인'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 11)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 7000냥을 획득했다!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '우유20L마시기'를 배웠다!";
                if(dialogIndex==2)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }
        else if(dialogID == 12)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0) 
                {
                    WarningMessage.text = "승리 상금 7000냥을 획득했다!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '철과 같은 단단함'을 배웠다!";
                if(dialogIndex==2) 
                {
                    WarningMessage.text = "세계대회 우승 트로피를 획득했다!";
                    Player.Item item = new Player.Item();
                    item.itemName = "세계대회 우승 트로피";
                    item.itemType = "기타";
                    item.itemPrice = 20000;
                    item.itemExplain = "세계대회 우승 트로피";
                    Player.inventory.Add(item);
                }
                if(dialogIndex==3)
                {
                    WarningMessage.text = "";
                    BattleOver();
                    dialogID = 0;
                    dialogIndex = -1;
                }
                dialogIndex++;
            }
        }

    }
    
    public void OnClickOK()
    {
        ImageVS.SetActive(false);
        turn = 1;

        if(MilkCowClear)
        {
            Skill3.SetActive(true);
        }
        if(YelloCowClear)
        {
            Skill4.SetActive(true);
        }
        if(KangKeonCowClear)
        {
            Skill5.SetActive(true);
        }
        if(BurningCowClear)
        {
            Skill6.SetActive(true);
        }
        if(MadCowClear)
        {
            Skill7.SetActive(true);
        }
        if(RockerCowClear)
        {
            Skill8.SetActive(true);
        }
        if(SeesawCowClear)
        {
            Skill9.SetActive(true);
        }
        if(WoodCowClear)
        {
            Skill10.SetActive(true);
        }
        if(CowboyCowClear)
        {
            Skill11.SetActive(true);
        }
        if(JapaneseCowClear)
        {
            Skill12.SetActive(true);
        }
        if(ElephantCowClear)
        {
            Skill13.SetActive(true);
        }
        if(GermanCowClear)
        {
            Skill14.SetActive(true);
        }
        if(SuperSaiyanCowClear)
        {
            Skill15.SetActive(true);
        }
    }

    public void StatusCheck()
    {
        if(cowBlind.activeSelf)
        {
            int cowBlindLeftInt = int.Parse(cowBlindLeft.text.Substring(11,1)) - 1;
            cowBlindLeft.text = "<color=red>" + cowBlindLeftInt.ToString() + "</color>";
            if(cowBlindLeftInt == 0)
            {
                cowBlind.SetActive(false);
            }
        }
        if(enemyCowBlind.activeSelf)
        {
            int enemyCowBlindLeftInt = int.Parse(enemyCowBlindLeft.text.Substring(11,1)) - 1;
            enemyCowBlindLeft.text = "<color=red>" + enemyCowBlindLeftInt.ToString() + "</color>";
            if(enemyCowBlindLeftInt == 0)
            {
                enemyCowBlind.SetActive(false);
            }
        }
        if(cowRage.activeSelf)
        {
            int cowRageLeftInt = int.Parse(cowRageLeft.text.Substring(12,1)) - 1;
            cowRageLeft.text = "<color=blue>" + cowRageLeftInt.ToString() + "</color>";
            if(cowRageLeftInt == 0)
            {
                cowRage.SetActive(false);
                StatusActivity("rage", "MyCow", false);
            }
        }
        if(enemyCowRage.activeSelf)
        {
            int enemyCowRageLeftInt = int.Parse(enemyCowRageLeft.text.Substring(12,1)) - 1;
            enemyCowRageLeft.text = "<color=blue>" + enemyCowRageLeftInt.ToString() + "</color>";
            if(enemyCowRageLeftInt == 0)
            {
                enemyCowRage.SetActive(false);
                StatusActivity("rage", "MyCow", false);
            }
        }
        if(cowBalanced.activeSelf)
        {
            int cowBalancedLeftInt = int.Parse(cowBalancedLeft.text.Substring(12,1)) - 1;
            cowBalancedLeft.text = "<color=blue>" + cowBalancedLeftInt.ToString() + "</color>";
            if(cowBalancedLeftInt == 0)
            {
                cowBalanced.SetActive(false);
            }
        }
        if(enemyCowBalanced.activeSelf)
        {
            int enemyCowBalancedLeftInt = int.Parse(enemyCowBalancedLeft.text.Substring(12,1)) - 1;
            enemyCowBalancedLeft.text = "<color=blue>" + enemyCowBalancedLeftInt.ToString() + "</color>";
            if(enemyCowBalancedLeftInt == 0)
            {
                enemyCowBalanced.SetActive(false);
            }
        }
        if(cowOnFire.activeSelf)
        {
            int cowOnFireLeftInt = int.Parse(cowOnFireLeft.text.Substring(11,1)) - 1;
            cowOnFireLeft.text = "<color=red>" + cowOnFireLeftInt.ToString() + "</color>";
            int dmg = 50;
            if(cowSteelization.activeSelf) dmg /= 2;
            MyCow.nowHP -= dmg;
            if(cowOnFireLeftInt == 0)
            {
                cowOnFire.SetActive(false);
                StatusActivity("onFire", "MyCow", false);
            }
        }
        if(enemyCowOnFire.activeSelf)
        {
            int enemyCowOnFireLeftInt = int.Parse(enemyCowOnFireLeft.text.Substring(11,1)) - 1;
            enemyCowOnFireLeft.text = "<color=red>" + enemyCowOnFireLeftInt.ToString() + "</color>";
            int dmg = 50;
            if(enemyCowSteelization.activeSelf) dmg /= 2;
            EnemyCow.nowHP -= dmg;
            if(enemyCowOnFireLeftInt == 0)
            {
                enemyCowOnFire.SetActive(false);
                StatusActivity("onFire", "EnemyCow", false);
            }
        }
        if(cowImmune.activeSelf)
        {
            int cowImmuneLeftInt = int.Parse(cowImmuneLeft.text.Substring(12,1)) - 1;
            cowImmuneLeft.text = "<color=blue>" + cowImmuneLeftInt.ToString() + "</color>";
            if(cowImmuneLeftInt == 0)
            {
                cowImmune.SetActive(false);
            }
        }
        if(enemyCowImmune.activeSelf)
        {
            int enemyCowImmuneLeftInt = int.Parse(enemyCowImmuneLeft.text.Substring(12,1)) - 1;
            enemyCowImmuneLeft.text = "<color=blue>" + enemyCowImmuneLeftInt.ToString() + "</color>";
            if(enemyCowImmuneLeftInt == 0)
            {
                enemyCowImmune.SetActive(false);
            }
        }
        if(cowSealed.activeSelf)
        {
            int cowSealedLeftInt = int.Parse(cowSealedLeft.text.Substring(11,1)) - 1;
            cowSealedLeft.text = "<color=red>" + cowSealedLeftInt.ToString() + "</color>";
            if(cowSealedLeftInt == 0)
            {
                cowSealed.SetActive(false);
                StatusActivity("sealed", "MyCow", false);
            }
        }
        if(enemyCowSealed.activeSelf)
        {
            int enemyCowSealedLeftInt = int.Parse(enemyCowSealedLeft.text.Substring(11,1)) - 1;
            enemyCowSealedLeft.text = "<color=red>" + enemyCowSealedLeftInt.ToString() + "</color>";
            if(enemyCowSealedLeftInt == 0)
            {
                enemyCowSealed.SetActive(false);
                StatusActivity("sealed", "EnemyCow", false);
            }
        }
        if(cowSteelization.activeSelf)
        {
            int cowSteelizationLeftInt = int.Parse(cowSteelizationLeft.text.Substring(12,1)) - 1;
            cowSteelizationLeft.text = "<color=blue>" + cowSteelizationLeftInt.ToString() + "</color>";
            if(cowSteelizationLeftInt == 0)
            {
                cowSteelization.SetActive(false);
            }
        }
        if(enemyCowSteelization.activeSelf)
        {
            int enemyCowSteelizationLeftInt = int.Parse(enemyCowSteelizationLeft.text.Substring(12,1)) - 1;
            enemyCowSteelizationLeft.text = "<color=blue>" + enemyCowSteelizationLeftInt.ToString() + "</color>";
            if(enemyCowSteelizationLeftInt == 0)
            {
                enemyCowSteelization.SetActive(false);
            }
        }
        if(cowSuperSaiyan.activeSelf)
        {
            int cowSuperSaiyanLeftInt = int.Parse(cowSuperSaiyanLeft.text.Substring(12,1)) - 1;
            cowSuperSaiyanLeft.text = "<color=blue>" + cowSuperSaiyanLeftInt.ToString() + "</color>";
            if(cowSuperSaiyanLeftInt == 0)
            {
                cowSuperSaiyan.SetActive(false);
                StatusActivity("superSaiyan", "MyCow", false);
            }
        }
        if(enemyCowSuperSaiyan.activeSelf)
        {
            int enemyCowSuperSaiyanLeftInt = int.Parse(enemyCowSuperSaiyanLeft.text.Substring(12,1)) - 1;
            enemyCowSuperSaiyanLeft.text = "<color=blue>" + enemyCowSuperSaiyanLeftInt.ToString() + "</color>";
            if(enemyCowSuperSaiyanLeftInt == 0)
            {
                enemyCowSuperSaiyan.SetActive(false);
                StatusActivity("superSaiyan", "EnemyCow", false);
            }
        }
    }

    // Status activity
    public void StatusActivity(string status, string cow, bool onoff)
    {
        if(status == "onFire")
        {
            if(cow == "MyCow")
            {
                if(onoff)
                {
                    MyCow.armor -= 50;
                }
                else
                {
                    MyCow.armor += 50;
                }
            }
            else
            {
                if(onoff)
                {
                    EnemyCow.armor -= 50;
                }
                else
                {
                    EnemyCow.armor += 50;
                }
            }
        }
        else if(status == "rage")
        {
            if(cow == "MyCow")
            {
                if(onoff)
                {
                    MyCow.atkDmg += 100;
                    MyCow.armor += 100;
                }
                else
                {
                    MyCow.atkDmg -= 100;
                    MyCow.armor -= 100;
                }
            }
            else
            {
                if(onoff)
                {
                    EnemyCow.atkDmg += 100;
                    EnemyCow.armor += 100;
                }
                else
                {
                    EnemyCow.atkDmg -= 100;
                    EnemyCow.armor -= 100;
                }
            }
        }
        else if(status == "sealed")
        {
            if(cow == "MyCow")
            {
                if(onoff)
                {
                    MyCow.atkDmg -= 200;
                    MyCow.armor -= 200;
                }
                else
                {
                    MyCow.atkDmg += 200;
                    MyCow.armor += 200;
                }
            }
            else
            {
                if(onoff)
                {
                    EnemyCow.atkDmg -= 200;
                    EnemyCow.armor -= 200;
                }
                else
                {
                    EnemyCow.atkDmg += 200;
                    EnemyCow.armor += 200;
                }
            }
        }
        else if(status == "superSaiyan")
        {
            if(cow == "MyCow")
            {
                if(onoff)
                {
                    MyCow.atkDmg += 300;
                    MyCow.armor += 200;
                }
                else
                {
                    MyCow.atkDmg -= 300;
                    MyCow.armor -= 200;
                }
            }
            else
            {
                if(onoff)
                {
                    EnemyCow.atkDmg += 300;
                    EnemyCow.armor += 200;
                }
                else
                {
                    EnemyCow.atkDmg -= 300;
                    EnemyCow.armor -= 200;
                }
            }
        }
            
    }

    public Text BattleLog;
    public Text WarningMessage;

    public void OnClickSkill(int skillID){
        Debug.Log("enemy armor " + EnemyCow.armor);
        if(myTurn == true)
        {
            StatusCheck();
            if(skillID == 0)
            {
                if(cowBlind.activeSelf)
                {
                    BattleLog.text += MyCow.cowName + "의 박치기! 하지만 빗나갔다!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        BattleLog.text += MyCow.cowName + "의 박치기! 하지만" + EnemyCow.enemyName + "은(는) 회피했다!\n";
                    }
                    else
                    {
                        int dmg = 0;
                        if(MyCow.atkDmg - EnemyCow.armor > 0)
                        {
                            dmg = MyCow.atkDmg - EnemyCow.armor;
                        }
                        else
                        {
                            dmg = 0;
                        }
                        if(enemyCowSteelization.activeSelf) dmg /= 2;
                        BattleLog.text += MyCow.cowName + "의 박치기!" + EnemyCow.enemyName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                        EnemyCow.nowHP -= dmg;
                    }
                }
                turnEnd = true;
            }
            else if(skillID == 1)
            {
                if(MyCow.nowMP < 20)
                {
                    WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
                }
                else
                {
                    MyCow.nowMP -= 20;
                    if(cowBlind.activeSelf)
                    {
                        BattleLog.text += MyCow.cowName + "의 핵꿀밤! 하지만 빗나갔다!\n";
                    }
                    else
                    {
                        if(enemyCowBalanced.activeSelf)
                        {
                            BattleLog.text += MyCow.cowName + "의 핵꿀밤! 하지만" + EnemyCow.enemyName + "은(는) 회피했다!\n";
                        }
                        else
                        {
                            int dmg = 0;
                            if(MyCow.atkDmg * 2 - EnemyCow.armor > 0)
                            {
                                dmg = MyCow.atkDmg - EnemyCow.armor;
                            }
                            else
                            {
                                dmg = 0;
                            }
                            if(enemyCowSteelization.activeSelf) dmg /= 2;
                            BattleLog.text += MyCow.cowName + "의 핵꿀밤! " + EnemyCow.enemyName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                            EnemyCow.nowHP -= dmg;
                        }
                    }
                    turnEnd = true;
                }
            }
            else if(skillID == 2)
            {
                BattleLog.text += MyCow.cowName + "의 우유마시기! <color=green>" + (int)((float)EnemyCow.maxHP / 10) + "</color>의 체력과 <color=blue>50</color>의 활력을 회복!\n";
                MyCow.nowHP += (int)((float)EnemyCow.maxHP / 10);
                MyCow.nowMP += 50;
                if(MyCow.nowHP > MyCow.maxHP)
                {
                    MyCow.nowHP = MyCow.maxHP;
                }
                if(MyCow.nowMP > MyCow.maxMP)
                {
                    MyCow.nowMP = MyCow.maxMP;
                }
                cowBlindLeft.text = "<color=red>0</color>";
                cowBlind.SetActive(false);
                if(cowOnFire.activeSelf)
                {
                    cowOnFireLeft.text = "<color=red>0</color>";
                    cowOnFire.SetActive(false);
                    StatusActivity("onFire", "EnemyCow", false);
                }
                turnEnd = true;
            }
            else if(skillID == 3)
            {
                if(MyCow.nowMP < 20)
                {
                    WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
                }
                else
                {
                    MyCow.nowMP -= 20;
                    if(cowBlind.activeSelf)
                    {
                        BattleLog.text += MyCow.cowName + "의 거름차기! " + EnemyCow.enemyName + "에게" + MyCow.atkDmg + "하지만 빗나갔다!\n";
                    }
                    else
                    {
                        if(enemyCowBalanced.activeSelf)
                        {
                            BattleLog.text += MyCow.cowName + "의 거름차기! 하지만" + EnemyCow.enemyName + "은(는) 회피했다!\n";
                        }
                        else
                        {
                            if(enemyCowImmune.activeSelf || enemyCowSuperSaiyan.activeSelf)
                            {
                                BattleLog.text += MyCow.cowName + "의 거름차기! 하지만 " + EnemyCow.enemyName + "은(는) 면역!\n";
                            }
                            else
                            {
                                BattleLog.text += MyCow.cowName + "의 거름차기! " + EnemyCow.enemyName + "은(는) 실명에 걸렸다!\n";
                                enemyCowBlind.SetActive(true);
                                enemyCowBlindLeft.text = "<color=red>4</color>";
                            }
                        }
                    }
                    turnEnd = true;
                }
            }
            else if(skillID == 4)
            {
                if(MyCow.nowMP < 30)
                {
                    WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
                }
                else
                {
                    MyCow.nowMP -= 30;
                    for(int i=0; i<3; i++)
                    {
                        if(cowBlind.activeSelf)
                        {
                            BattleLog.text += MyCow.cowName + "의 3단컴보! 하지만 빗나갔다!\n";
                        }
                        else
                        {
                            if(enemyCowBalanced.activeSelf)
                            {
                                BattleLog.text += MyCow.cowName + "의 3단컴보! 하지만" + EnemyCow.enemyName + "은(는) 회피했다!\n";
                            }
                            else
                            {
                                int dmg = 0;
                                if(MyCow.atkDmg - EnemyCow.armor > 0)
                                {
                                   dmg = MyCow.atkDmg - EnemyCow.armor;
                                }
                                else
                                {
                                    dmg = 0;
                                }
                                if(enemyCowSteelization.activeSelf) dmg /= 2;
                                BattleLog.text += MyCow.cowName + "의 3단컴보! " + EnemyCow.enemyName + "에게 " + dmg +"의 데미지를 입혔다!\n";
                                EnemyCow.nowHP -= dmg;
                            }
                        }
                    }
                    turnEnd = true;
                }
            }
            else if(skillID == 5)
            {
                int dmg = 500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                BattleLog.text += MyCow.cowName + "의 불고기! " + EnemyCow.enemyName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                EnemyCow.nowHP -= dmg;
                if(!enemyCowOnFire.activeSelf && !enemyCowImmune.activeSelf && !enemyCowSuperSaiyan.activeSelf)
                {
                    enemyCowOnFire.SetActive(true);
                    StatusActivity("onFire", "EnemyCow", true);
                }
                enemyCowOnFireLeft.text = "<color=red>4</color>";
                turnEnd = true;
            }
            else if(skillID == 6)
            {
                BattleLog.text += MyCow.cowName + "의 크로이츠펠트 야곱병! " + MyCow.cowName + "은(는) 광폭 상태가 되었다!\n";
                if(!cowRage.activeSelf)
                {
                    Debug.Log("cowRage");
                    cowRage.SetActive(true);
                    StatusActivity("rage", "MyCow", true);
                }
                cowRageLeft.text = "<color=blue>6</color>";
                turnEnd = true;
            }

            if(EnemyCow.nowHP <= 0)
            {
                BattleWin();
                return;
            }
            
            if(turnEnd == true)
            {
                WarningMessage.text = "";
                scroll_rect.verticalNormalizedPosition = 0.0f;
                myTurn = false;
                turn++;
                // 시간 딜레이
                Invoke("EnemyAct", 1.0f);
                turnEnd = false;
            }
        }
    }

    public void EnemyAct(){
        Debug.Log(EnemyCow.enemyName);
        if(EnemyCow.enemyName == "젖소"){
            if(((float)EnemyCow.nowHP/(float)EnemyCow.maxHP) <= 0.5)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    EnemySkill("박치기");
                }
                else
                {
                    EnemySkill("우유마시기");
                }
            }
            else
            {
                EnemySkill("박치기");
            }
        }
        turn++;
        StatusCheck();
        myTurn = true;
    }

    public void EnemySkill(string skill_name){
        if(skill_name == "박치기")
        {
            if(enemyCowBlind.activeSelf)
            {
                BattleLog.text += EnemyCow.enemyName + "의 박치기! 하지만 빗나갔다!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    BattleLog.text += EnemyCow.enemyName + "의 박치기! 하지만 " + MyCow.cowName + "은(는) 회피했다!\n";
                }
                else
                {
                    int dmg = 0;
                    if(EnemyCow.atkDmg - MyCow.armor > 0)
                    {
                        dmg = EnemyCow.atkDmg - MyCow.armor;
                    }
                    else
                    {
                        dmg = 0;
                    }
                    BattleLog.text += EnemyCow.enemyName + "의 박치기! <color=red>" + dmg + "</color>의 피해를 입었다!\n";
                    MyCow.nowHP -= dmg;

                }
            }
        }
        else if(skill_name == "우유마시기")
        {
            BattleLog.text += EnemyCow.enemyName + "의 우유마시기! <color=green>" + (int)((float)EnemyCow.maxHP / 10) + "</color>의 체력을 회복!\n";
            EnemyCow.nowHP += (int)((float)EnemyCow.maxHP / 10);
            if(EnemyCow.nowHP > EnemyCow.maxHP)
            {
                EnemyCow.nowHP = EnemyCow.maxHP;
            }
        }
    }

    public void BattleWin()
    {
        Debug.Log("승리!");
        if(EnemyCow.enemyName == "젖소")
        {
            MilkCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("누렁이", 1500, 150, 30);
            dialogID = 1;
                
        }
        else if(EnemyCow.enemyName == "누렁이")
        {
            YelloCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("우건마", 2000, 150, 50);
            dialogID = 2;
        }
        else if(EnemyCow.enemyName == "우건마")
        {
            KangKeonCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("불판에서 뛰쳐나온 소", 3000, 200, 50);
            dialogID = 3;
        }
        else if(EnemyCow.enemyName == "불판에서 뛰쳐나온 소")
        {
            BurningCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("광우병소", 4000, 200, 100);
            dialogID = 4;
        }
        else if(EnemyCow.enemyName == "광우병소")
        {
            MadCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("롹커소", 5000, 300, 100);
            dialogID = 5;
        }
        else if(EnemyCow.enemyName == "롹커소")
        {
            RockerCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("시소", 6000, 500, 100);
            dialogID = 6;
        }
        else if(EnemyCow.enemyName == "시소")
        {
            SeesawCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("조소", 8000, 700, 400);
            dialogID = 7;
        }
        else if(EnemyCow.enemyName == "조소")
        {
            WoodCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("카우보이소", 10000, 700, 200);
            dialogID = 8;
        }
        else if(EnemyCow.enemyName == "카우보이소")
        {
            ElephantCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("마법'소'녀", 12000, 1000, 300);
            dialogID = 9;
        }
        else if(EnemyCow.enemyName == "마법'소'녀")
        {
            ElephantCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("인도소", 15000, 1000, 500);
            dialogID = 10;
        }
        else if(EnemyCow.enemyName == "인도소")
        {
            ElephantCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("독일소", 15000, 1200, 800);
            dialogID = 11;
        }
            // Debug.Log("클리어!");
            // SceneManager.LoadScene("EndingScene");
            // return;

        
    }
    public GameObject Cowshed;
    public GameObject BullFight;
    public GameObject TopMenuBar;
    public GameObject ToVillage;
    public GameObject To_Village;
    public void BattleOver()
    {
        MyCow.nowHP = MyCow.maxHP;
        MyCow.nowMP = MyCow.maxMP;
        BattleLog.text = "";
        // SceneManager.LoadScene("VillageScene");
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
        Cowshed.SetActive(true);
        BullFight.SetActive(false);
        TopMenuBar.SetActive(true);
    }

}

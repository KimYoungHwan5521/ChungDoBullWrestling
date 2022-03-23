using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BullFightScript : MonoBehaviour
{
    // AudioClips
    public AudioPlayer AudioManager;
    public AudioClip TownTheme;
    public AudioClip Fanfare;
    public AudioClip Hit, Hit2, Drinking, KickManure, Fire, Rage, Shouting, Heal, GunFire, Seal, SuperSaiyanTransformation;
    public AudioClip AvoidSound, WarningSound;
    public AudioClip Chainsaw, Explosion, DeathMetal, Earthquake, ForkrainSound, Elephant, ElectricGuitar, Thunder, RocketLunch, Engine;
    
    //
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
    public GameObject cowElectricShock;
    
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
    public Text cowElectricShockLeft;

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

    public Button btnSkill1;
    public Button btnSkill2;
    public Button btnSkill3;
    public Button btnSkill4;
    public Button btnSkill5;
    public Button btnSkill6;
    public Button btnSkill7;
    public Button btnSkill8;
    public Button btnSkill9;
    public Button btnSkill10;
    public Button btnSkill11;
    public Button btnSkill12;
    public Button btnSkill13;
    public Button btnSkill14;
    public Button btnSkill15;

    public GameObject Skill1Blocked;
    public GameObject Skill2Blocked;
    public GameObject Skill3Blocked;
    public GameObject Skill4Blocked;
    public GameObject Skill5Blocked;
    public GameObject Skill6Blocked;
    public GameObject Skill7Blocked;
    public GameObject Skill8Blocked;
    public GameObject Skill9Blocked;
    public GameObject Skill10Blocked;
    public GameObject Skill11Blocked;
    public GameObject Skill12Blocked;
    public GameObject Skill13Blocked;
    public GameObject Skill14Blocked;
    public GameObject Skill15Blocked;

    public ScrollRect scroll_rect;
    public void MouseOverToSkill(int skillID)
    {
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
            Skill_Explanation.text = "우유를 마셔 모든 해로운 상태이상을 제거하고, 체력과 활력을 조금 회복한다.";
        }
        else if(skillID == 3)
        {
            Skill_Name.text = "뒷발로 거름차기";
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
            Mana_Required.text = "<color=blue>활력 30</color>";
            Skill_Explanation.text = "강력한 샤우팅으로 상대에게 고정피해를 입히고 이로운 상태를 날려버린다.";
        }
        else if(skillID == 8)
        {
            Skill_Name.text = "균형잡기";
            Mana_Required.text = "<color=blue>활력 50</color>";
            Skill_Explanation.text = "균형을 잡아 상대의 스킬을 회피할 수 있는 상태가 되고, 모든 해로운 상태이상을 제거하고 면역상태가 된다.";
        }
        else if(skillID == 9)
        {
            Skill_Name.text = "운기조식";
            Mana_Required.text = "<color=blue>활력 0</color>";
            Skill_Explanation.text = "정신을 집중해 활력을 회복한다.";
        }
        else if(skillID == 10)
        {
            Skill_Name.text = "총쏘기";
            Mana_Required.text = "<color=blue>활력 50</color>";
            Skill_Explanation.text = "총을 쏜다.";
        }
        else if(skillID == 11)
        {
            Skill_Name.text = "봉인";
            Mana_Required.text = "<color=blue>활력 80</color>";
            Skill_Explanation.text = "적을 봉인하여 고정피해를 입히고 공격력과 방어력을 감소시킨다.";
        }
        else if(skillID == 12)
        {
            Skill_Name.text = "우유 20L 마시기";
            Mana_Required.text = "<color=blue>활력 50</color>";
            Skill_Explanation.text = "우유를 엄청나게 들이켜 체력을 크게 회복하고 모든 해로운 상태이상을 제거한다.";
        }
        else if(skillID == 13)
        {
            Skill_Name.text = "철과 같은 단단함";
            Mana_Required.text = "<color=blue>활력 0</color>";
            Skill_Explanation.text = "방어를 준비해 적의 다음공격의 피해를 절반으로 줄인다.";
        }
        else if(skillID == 14)
        {
            Skill_Name.text = "초사이언 변신";
            Mana_Required.text = "<color=blue>활력 100</color>";
            Skill_Explanation.text = "초사이언으로 변신해 모든 해로운 상태이상을 제거하고 면역상태가 되며 공격력과 방어력이 증가한다.";
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
        else if(skillID == 1008)
        {
            Skill_Name.text = "<color=red>감전</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "물리공격을 사용할 수 없게된다.";
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

    // Update is called once per frame
    public int dialogID = 0;
    public int dialogIndex = 0;
    public GameObject GameManager;
    void Update()
    {
        Debug.Log(turn);
        Sprite[] itemSprites = GameManager.GetComponent<GameManager>().ItemSprites;
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
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "은(는) 기술 '뒷발로 거름차기'를 배웠다!";
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
                    item.itemSprite = itemSprites[7];
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
                    item.itemSprite = itemSprites[8];
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
        else if(dialogID == 11)
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
                    item.itemSprite = itemSprites[9];
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
        myTurn = true;
        turn = 1;
        turnText.text = "나의 턴!";

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
            if(EnemyCow.cowName == "조소")
            {
                enemyCowOnFireLeftInt += 2;
                BattleLog.text += "조소의 불이 옮겨붙었다!\n";
            }
            enemyCowOnFireLeft.text = "<color=red>" + enemyCowOnFireLeftInt.ToString() + "</color>";
            int dmg = 50;
            if(EnemyCow.cowName == "조소") dmg *= 2;
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
        if(cowElectricShock.activeSelf)
        {
            int cowElectricShockLeftInt = int.Parse(cowElectricShockLeft.text.Substring(11,1)) - 1;
            cowElectricShockLeft.text = "<color=red>" + cowElectricShockLeftInt.ToString() + "</color>";
            if(cowElectricShockLeftInt == 0)
            {
                cowElectricShock.SetActive(false);
                StatusActivity("electricShock", "MyCow", false);
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
                    Debug.Log("onFire, MyCow, on " + MyCow.armor);
                    MyCow.armor -= 50;
                }
                else
                {
                    Debug.Log("onFire, MyCow, off " + MyCow.armor);
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
                    Debug.Log("rage, MyCow, on " + MyCow.armor);
                    MyCow.atkDmg += 100;
                    MyCow.armor += 100;
                }
                else
                {
                    Debug.Log("rage, MyCow, off " + MyCow.armor);
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
        else if(status == "electricShock")
        {
            if(onoff)
            {
                Skill1Blocked.SetActive(true);
                btnSkill1.interactable = false;
                Skill2Blocked.SetActive(true);
                btnSkill2.interactable = false;
                Skill4Blocked.SetActive(true);
                btnSkill4.interactable = false;
                Skill5Blocked.SetActive(true);
                btnSkill5.interactable = false;
                Skill11Blocked.SetActive(true);
                btnSkill11.interactable = false;
            }
            else
            {
                Skill1Blocked.SetActive(false);
                btnSkill1.interactable = true;
                Skill2Blocked.SetActive(false);
                btnSkill2.interactable = true;
                Skill4Blocked.SetActive(false);
                btnSkill4.interactable = true;
                Skill5Blocked.SetActive(false);
                btnSkill5.interactable = true;
                Skill11Blocked.SetActive(false);
                btnSkill11.interactable = true;
            }
        }
            
    }

    public Text BattleLog;
    public Text WarningMessage;

    public void OnClickSkill(int skillID){
        if(myTurn == true)
        {
            StartCoroutine(SkillActive(skillID));
        }
    }

    IEnumerator SkillActive(int skillID)
    {
        myTurn = false;
        if(skillID == 0)
        {
            if(cowBlind.activeSelf)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                BattleLog.text += MyCow.cowName + "의 박치기! 하지만 빗나갔다!\n";
            }
            else
            {
                if(enemyCowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += MyCow.cowName + "의 박치기! 하지만" + EnemyCow.cowName + "은(는) 회피했다!\n";
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
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit);
                    BattleLog.text += MyCow.cowName + "의 박치기!" + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                    EnemyCow.nowHP -= dmg;
                }
            }
            turnEnd = true;
        }
        else if(skillID == 1)
        {
            if(MyCow.nowMP < 20)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 20;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += MyCow.cowName + "의 핵꿀밤! 하지만 빗나갔다!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                        BattleLog.text += MyCow.cowName + "의 핵꿀밤! 하지만" + EnemyCow.cowName + "은(는) 회피했다!\n";
                    }
                    else
                    {
                        int dmg = 0;
                        if(MyCow.atkDmg * 2 - EnemyCow.armor > 0)
                        {
                            dmg = MyCow.atkDmg * 2 - EnemyCow.armor;
                        }
                        else
                        {
                            dmg = 0;
                        }
                        if(enemyCowSteelization.activeSelf) dmg /= 2;
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit2);
                        BattleLog.text += MyCow.cowName + "의 핵꿀밤! " + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                        EnemyCow.nowHP -= dmg;
                    }
                }
                turnEnd = true;
            }
        }
        else if(skillID == 2)
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
            BattleLog.text += MyCow.cowName + "의 우유마시기! <color=green>" + (MyCow.maxHP / 10) + "</color>의 체력과 <color=blue>50</color>의 활력을 회복!\n";
            MyCow.nowHP += (EnemyCow.maxHP / 10);
            MyCow.nowMP += 50;
            if(MyCow.nowHP > MyCow.maxHP) MyCow.nowHP = MyCow.maxHP;
            if(MyCow.nowMP > MyCow.maxMP) MyCow.nowMP = MyCow.maxMP;
            cowBlindLeft.text = "<color=red>0</color>";
            cowBlind.SetActive(false);
            if(cowOnFire.activeSelf)
            {
                cowOnFireLeft.text = "<color=red>0</color>";
                cowOnFire.SetActive(false);
                StatusActivity("onFire", "MyCow", false);
            }
            if(cowSealed.activeSelf)
            {
                cowSealedLeft.text = "<color=red>0</color>";
                cowSealed.SetActive(false);
                StatusActivity("sealed", "MyCow", false);
            }
            turnEnd = true;
        }
        else if(skillID == 3)
        {
            if(MyCow.nowMP < 20)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 20;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                    BattleLog.text += MyCow.cowName + "의 거름차기! 하지만 빗나갔다!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                        BattleLog.text += MyCow.cowName + "의 거름차기! 하지만" + EnemyCow.cowName + "은(는) 회피했다!\n";
                    }
                    else
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                        if(enemyCowImmune.activeSelf || enemyCowSuperSaiyan.activeSelf)
                        {
                            BattleLog.text += MyCow.cowName + "의 거름차기! 하지만 " + EnemyCow.cowName + "은(는) 면역!\n";
                        }
                        else
                        {
                            BattleLog.text += MyCow.cowName + "의 거름차기! " + EnemyCow.cowName + "은(는) 실명에 걸렸다!\n";
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
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 30;
                for(int i=0; i<3; i++)
                {
                    if(cowBlind.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                        yield return new WaitForSeconds(0.5f);
                        BattleLog.text += MyCow.cowName + "의 3단컴보! 하지만 빗나갔다!\n";
                    }
                    else
                    {
                        if(enemyCowBalanced.activeSelf)
                        {
                            AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                            yield return new WaitForSeconds(0.5f);
                            BattleLog.text += MyCow.cowName + "의 3단컴보! 하지만" + EnemyCow.cowName + "은(는) 회피했다!\n";
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
                            AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit);
                            BattleLog.text += MyCow.cowName + "의 3단컴보! " + EnemyCow.cowName + "에게 <color=red>" + dmg +"</color>의 데미지를 입혔다!\n";
                            EnemyCow.nowHP -= dmg;
                            yield return new WaitForSeconds(0.5f);
                        }
                    }
                }
                turnEnd = true;
            }
        }
        else if(skillID == 5)
        {
            if(MyCow.nowMP < 40)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 40;
                int dmg = 500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Fire);
                BattleLog.text += MyCow.cowName + "의 불고기! " + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                EnemyCow.nowHP -= dmg;
                if(!enemyCowOnFire.activeSelf && !enemyCowImmune.activeSelf && !enemyCowSuperSaiyan.activeSelf)
                {
                    enemyCowOnFire.SetActive(true);
                    StatusActivity("onFire", "EnemyCow", true);
                }
                enemyCowOnFireLeft.text = "<color=red>4</color>";
                turnEnd = true;

            }
        }
        else if(skillID == 6)
        {
            if(MyCow.nowMP < 30)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 30;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Rage);
                BattleLog.text += MyCow.cowName + "의 크로이츠펠트 야곱병! " + MyCow.cowName + "은(는) 광폭 상태가 되었다!\n";
                if(!cowRage.activeSelf)
                {
                    cowRage.SetActive(true);
                    StatusActivity("rage", "MyCow", true);
                }
                cowRageLeft.text = "<color=blue>6</color>";
                turnEnd = true;
            }
        }
        else if(skillID == 7)
        {
            if(MyCow.nowMP < 30)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 30;
                int dmg = 500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Shouting);
                BattleLog.text += MyCow.cowName + "의 샤우팅! " + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                EnemyCow.nowHP -= dmg;
                if(enemyCowRage.activeSelf)
                {
                    enemyCowRage.SetActive(false);
                    StatusActivity("rage", "EnemyCow", false);
                }
                enemyCowBalanced.SetActive(false);
                enemyCowBalancedLeft.text = "<color=blue>0</color>";
                enemyCowImmune.SetActive(false);
                enemyCowImmuneLeft.text = "<color=blue>0</color>";
                enemyCowSteelization.SetActive(false);
                enemyCowSteelizationLeft.text = "<color=blue>0</color>";
                if(enemyCowSuperSaiyan.activeSelf)
                {
                    enemyCowSuperSaiyan.SetActive(false);
                    StatusActivity("superSaiyan", "EnemyCow", false);
                }
                turnEnd = true;

            }
        }
        else if(skillID == 8)
        {
            if(MyCow.nowMP < 50)
            {
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
            }
            else
            {
                MyCow.nowMP -= 50;
                BattleLog.text += MyCow.cowName + "의 균형잡기! " + MyCow.cowName + "은(는) 균형 상태가 되었다!\n";
                cowBlindLeft.text = "<color=red>0</color>";
                cowBlind.SetActive(false);
                if(cowOnFire.activeSelf)
                {
                    cowOnFireLeft.text = "<color=red>0</color>";
                    cowOnFire.SetActive(false);
                    StatusActivity("onFire", "MyCow", false);
                }
                if(cowSealed.activeSelf)
                {
                    cowSealedLeft.text = "<color=red>0</color>";
                    cowSealed.SetActive(false);
                    StatusActivity("sealed", "MyCow", false);
                }
                cowImmuneLeft.text = "<color=blue>6</color>";
                cowImmune.SetActive(true);
                cowBalancedLeft.text = "<color=blue>6</color>";
                cowBalanced.SetActive(true);
                turnEnd = true;
            }
        }
        else if(skillID == 9)
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Heal);
            BattleLog.text += MyCow.cowName + "의 운기조식! <color=blue>200</color>의 활력을 회복!\n";
            MyCow.nowMP += 200;
            if(MyCow.nowMP > MyCow.maxMP) MyCow.nowMP = MyCow.maxMP;
            turnEnd = true;
        }
        else if(skillID == 10)
        {
            if(MyCow.nowMP < 50)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 50;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
                    BattleLog.text += MyCow.cowName + "의 총쏘기! 하지만 빗나갔다!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
                        BattleLog.text += MyCow.cowName + "의 총쏘기! 하지만" + EnemyCow.cowName + "은(는) 회피했다!\n";
                    }
                    else
                    {
                        int dmg = 0;
                        if(MyCow.atkDmg * 5 - EnemyCow.armor > 0)
                        {
                            dmg = MyCow.atkDmg * 5 - EnemyCow.armor;
                        }
                        else
                        {
                            dmg = 0;
                        }
                        if(enemyCowSteelization.activeSelf) dmg /= 2;
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
                        BattleLog.text += MyCow.cowName + "의 총쏘기! " + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                        EnemyCow.nowHP -= dmg;
                    }
                }
                turnEnd = true;
            }
        }
        else if(skillID == 11)
        {
            if(MyCow.nowMP < 80)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 80;
                int dmg = 2500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Seal);
                BattleLog.text += MyCow.cowName + "의 봉인! " + EnemyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
                EnemyCow.nowHP -= dmg;
                if(!enemyCowSealed.activeSelf && !enemyCowImmune.activeSelf && !enemyCowSuperSaiyan.activeSelf)
                {
                    enemyCowSealed.SetActive(true);
                    StatusActivity("sealed", "EnemyCow", true);
                }
                enemyCowSealedLeft.text = "<color=red>4</color>";
                turnEnd = true;
            }
        }
        else if(skillID == 12)
        {
            if(MyCow.nowMP < 50)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 50;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
                BattleLog.text += MyCow.cowName + "의 우유 20L 마시기! <color=green>" + (MyCow.maxHP * 3 / 10) + "</color>의 체력을 회복!\n";
                MyCow.nowHP += (EnemyCow.maxHP * 3 / 10);
                if(MyCow.nowHP > MyCow.maxHP) MyCow.nowHP = MyCow.maxHP;
                cowBlindLeft.text = "<color=red>0</color>";
                cowBlind.SetActive(false);
                if(cowOnFire.activeSelf)
                {
                    cowOnFireLeft.text = "<color=red>0</color>";
                    cowOnFire.SetActive(false);
                    StatusActivity("onFire", "MyCow", false);
                }
                if(cowSealed.activeSelf)
                {
                    cowSealedLeft.text = "<color=red>0</color>";
                    cowSealed.SetActive(false);
                    StatusActivity("sealed", "MyCow", false);
                }
                turnEnd = true;
            }
        }
        else if(skillID == 13)
        {
            BattleLog.text += MyCow.cowName + "의 철과 같은 단단함!" + MyCow.cowName + "은(는) 단단해졌다!\n";
            cowSteelizationLeft.text = "<color=blue>2</color>";
            cowSteelization.SetActive(true);
            turnEnd = true;
        }
        else if(skillID == 14)
        {
            if(MyCow.nowMP < 100)
            {
                WarningMessage.text = "<color=blue>활력</color>이 부족합니다!";
            }
            else
            {
                MyCow.nowMP -= 100;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(SuperSaiyanTransformation);
                BattleLog.text += MyCow.cowName + "의 초사이언 변신!" + MyCow.cowName + "은(는) 초사이언이 되었다!\n";
                cowBlindLeft.text = "<color=red>0</color>";
                cowBlind.SetActive(false);
                if(cowOnFire.activeSelf)
                {
                    cowOnFireLeft.text = "<color=red>0</color>";
                    cowOnFire.SetActive(false);
                    StatusActivity("onFire", "MyCow", false);
                }
                if(cowSealed.activeSelf)
                {
                    cowSealedLeft.text = "<color=red>0</color>";
                    cowSealed.SetActive(false);
                    StatusActivity("sealed", "MyCow", false);
                }
                cowSuperSaiyanLeft.text = "<color=blue>8</color>";
                cowSuperSaiyan.SetActive(true);
                turnEnd = true;
            }
        }

        yield return new WaitForSeconds(0.5f);
        if(EnemyCow.nowHP <= 0)
        {
            StartCoroutine(BattleWin());
        }
        else if(turnEnd == true)
        {
            turn++;
            myTurn = false;
            StatusCheck();
            turnText.text = "상대의 턴!";
            yield return new WaitForSeconds(1f);
            StartCoroutine(EnemyAct());
        }
        else
        {
            myTurn = true;
        }
    }

    IEnumerator EnemyAct()
    {
        WarningMessage.text = "";
        
        if(EnemyCow.cowName == "젖소")
        {
            if(((float)EnemyCow.nowHP/(float)EnemyCow.maxHP) < 0.5f)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
                else
                {
                    StartCoroutine(EnemySkill("우유마시기"));
                }
            }
            else
            {
                StartCoroutine(EnemySkill("박치기"));
            }
        }
        else if(EnemyCow.cowName == "누렁이")
        {
            if(!cowBalanced.activeSelf)
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("뒷발로 거름차기"));
                }
                else
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
            }
        }
        else if(EnemyCow.cowName == "우건마")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.2f)
            {
                StartCoroutine(EnemySkill("8단컴보"));
            }
            else
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("3단컴보"));
                }
                else
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
            }
        }
        else if(EnemyCow.cowName == "불판에서 뛰쳐나온 소")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(cowOnFire.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("우유마시기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("포크레인"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                }
                else
                {
                    int r = Random.Range(0,4);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("우유마시기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("포크레인"));
                    }
                    else if(r == 2)
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("불고기"));
                    }
                }
            }
            else
            {
                if(cowOnFire.activeSelf)
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("불고기"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "미친소")
        {
            if(enemyCowRage.activeSelf)
            {
                if(enemyCowBlind.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("우유마시기"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("연속공격"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("연속공격"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                }
            }
            else
            {
                StartCoroutine(EnemySkill("크로이츠펠트 야곱병"));
            }
        }
        else if(EnemyCow.cowName == "롹커소")
        {
            if(cowRage.activeSelf)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("샤우팅"));
                }
                else
                {
                    StartCoroutine(EnemySkill("날카로운 선율"));
                }
            }
            else
            {
                if(enemyCowRage.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("샤우팅"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("날카로운 선율"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("데스메탈"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("날카로운 선율"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "시소")
        {
            if(enemyCowBalanced.activeSelf)
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("연속공격"));
                }
                else
                {
                    StartCoroutine(EnemySkill("뒷발로 거름차기"));
                }
            }
            else
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("박치기"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("연속공격"));
                }
                else
                {
                    StartCoroutine(EnemySkill("균형잡기"));
                }
            }
        }
        else if(EnemyCow.cowName == "조소")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("천벌"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("몸통박치기"));
                }
                else
                {
                    StartCoroutine(EnemySkill("운기조식"));
                }
            }
            else
            {
                if(enemyCowRage)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("천벌"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("몸통박치기"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("천벌"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("몸통박치기"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("자연의 분노"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "카우보이소")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(enemyCowBalanced.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("총쏘기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("다이너마이트"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("총쏘기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("다이너마이트"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("황야의 무법자"));
                    }
                }
            }
            else
            {
                if(enemyCowBalanced.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("연속공격"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("박치기"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("연속공격"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("황야의 무법자"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "인도소")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("우렁찬 울음소리"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("몸통박치기"));
                }
                else
                {
                    StartCoroutine(EnemySkill("우유 20L 마시기"));
                }
            }
            else
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("우렁찬 울음소리"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("몸통박치기"));
                }
                else
                {
                    StartCoroutine(EnemySkill("발구르기"));
                }
            }
        }
        else if(EnemyCow.cowName == "마법'소'녀")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("큐어"));
                }
                if(r == 1)
                {
                    StartCoroutine(EnemySkill("봉인"));
                }
            }
            else
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("파이어볼"));
                }
                if(r == 1)
                {
                    StartCoroutine(EnemySkill("썬더스톰"));
                }
                if(r == 2)
                {
                    StartCoroutine(EnemySkill("포크레인"));
                }
            }
        }
        else if(EnemyCow.cowName == "독일소")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(enemyCowRage.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("뿔미사일"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("화염방사"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("뿔미사일"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("화염방사"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("엔진 최대출력"));
                    }
                }
            }
            else
            {
                if(enemyCowRage.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("소 도축 장치"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("철과 같은 단단함"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("소 도축 장치"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("철과 같은 단단함"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("엔진 최대출력"));
                    }
                }
            }
            
        }
        yield return new WaitForSeconds(0.5f);
        scroll_rect.verticalNormalizedPosition = 0.0f;
        StatusCheck();
        turn++;
        turnEnd = false;
        myTurn = true;
        turnText.text = "나의 턴!";
        
    }

    IEnumerator EnemySkill(string skill_name)
    {
        if(skill_name == "박치기" || skill_name == "몸통박치기" || skill_name == "소 도축 장치")
        {
            if(enemyCowBlind.activeSelf)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 빗나갔다!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 " + MyCow.cowName + "은(는) 회피했다!\n";
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
                    if(cowSteelization.activeSelf) dmg /= 2;
                    if(skill_name == "소 도축 장치")
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Chainsaw);
                    }
                    else
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit);
                    }
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=red>" + dmg + "</color>의 피해를 입었다!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "우유마시기" || skill_name == "우유 20L 마시기" || skill_name == "큐어")
        {
            if(skill_name == "큐어")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Heal);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
            }
            if(skill_name == "우유마시기")
            {
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=green>" + (EnemyCow.maxHP / 10) + "</color>의 체력을 회복!\n";
                EnemyCow.nowHP += (EnemyCow.maxHP / 10);
            }
            else if(skill_name == "우유 20L 마시기" || skill_name == "큐어")
            {
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=green>" + (EnemyCow.maxHP * 3 / 10) + "</color>의 체력을 회복!\n";
                EnemyCow.nowHP += (EnemyCow.maxHP * 3 / 10);
            }
            if(EnemyCow.nowHP > EnemyCow.maxHP) EnemyCow.nowHP = EnemyCow.maxHP;
            enemyCowBlindLeft.text = "<color=red>0</color>";
            enemyCowBlind.SetActive(false);
            if(enemyCowOnFire.activeSelf)
            {
                enemyCowOnFireLeft.text = "<color=red>0</color>";
                enemyCowOnFire.SetActive(false);
                StatusActivity("onFire", "EnemyCow", false);
            }
            if(enemyCowSealed.activeSelf)
            {
                enemyCowSealedLeft.text = "<color=red>0</color>";
                enemyCowSealed.SetActive(false);
                StatusActivity("sealed", "EnemyCow", false);
            }
        }
        else if(skill_name == "뒷발로 거름차기")
        {
            if(enemyCowBlind.activeSelf)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 빗나갔다!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만" + MyCow.cowName + "은(는) 회피했다!\n";
                }
                else
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                    if(cowImmune.activeSelf || cowSuperSaiyan.activeSelf)
                    {
                        BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 " + MyCow.cowName + "은(는) 면역!\n";
                    }
                    else
                    {
                        BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "은(는) 실명에 걸렸다!\n";
                        cowBlind.SetActive(true);
                        cowBlindLeft.text = "<color=red>4</color>";
                    }
                }
            }
        }
        else if(skill_name == "3단컴보" || skill_name == "8단컴보" || skill_name == "연속공격")
        {
            int i=0;
            if(skill_name == "3단컴보") i = 3;
            else if(skill_name == "8단컴보") i = 8;
            else i = 2;
            for(int j = 0;j < i;j++)
            {
                if(enemyCowBlind.activeSelf)
                {
                    if(skill_name == "8단컴보")
                    {
                        yield return new WaitForSeconds(0.2f);
                    }
                    else
                    {
                        yield return new WaitForSeconds(0.5f);
                    }
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 빗나갔다!\n";
                }
                else
                {
                    if(cowBalanced.activeSelf)
                    {
                        if(skill_name == "8단컴보")
                        {
                            yield return new WaitForSeconds(0.2f);
                        }
                        else
                        {
                            yield return new WaitForSeconds(0.5f);
                        }
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                        BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만" + MyCow.cowName + "은(는) 회피했다!\n";
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
                        if(cowSteelization.activeSelf) dmg /= 2;
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit);
                        if(skill_name == "8단컴보")
                        {
                            yield return new WaitForSeconds(0.2f);
                        }
                        else
                        {
                            yield return new WaitForSeconds(0.5f);
                        }
                        BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "에게 <color=red>" + dmg +"</color>의 데미지를 입혔다!\n";
                        MyCow.nowHP -= dmg;
                    }
                }
            }
        }
        else if(skill_name == "불고기" || skill_name == "다이너마이트" || skill_name == "파이어볼" || skill_name == "화염방사")
        {
            int dmg = 300;
            if(skill_name == "다이너마이트") dmg = 1000;
            if(skill_name == "파이어볼" || skill_name == "화염방사") dmg = 1500;
            if(cowSteelization.activeSelf) dmg /= 2;
            if(skill_name == "다이너마이트")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Explosion);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Fire);
            }
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
            MyCow.nowHP -= dmg;
            if(!cowOnFire.activeSelf && !cowImmune.activeSelf && !cowSuperSaiyan.activeSelf)
            {
                cowOnFire.SetActive(true);
                StatusActivity("onFire", "MyCow", true);
            }
            cowOnFireLeft.text = "<color=red>4</color>";
        }
        else if(skill_name == "포크레인" || skill_name == "날카로운 선율" || skill_name == "발구르기")
        {
            int dmg = 0;
            if(EnemyCow.atkDmg * 2 - MyCow.armor > 0)
            {
                dmg = EnemyCow.atkDmg * 2 - MyCow.armor;
            }
            else
            {
                dmg = 0;
            }
            if(cowSteelization.activeSelf) dmg /= 2;
            if(skill_name == "포크레인")
            {
                StartCoroutine(Forkrain());
            }
            else if(skill_name == "날카로운 선율")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(ElectricGuitar);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Earthquake);
            }
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=red>" + dmg + "</color>의 피해를 입었다!\n";
            MyCow.nowHP -= dmg;
        }
        else if(skill_name == "크로이츠펠트 야곱병" || skill_name == "데스메탈" || skill_name == "자연의 분노" || skill_name == "엔진 최대출력")
        {
            if(skill_name == "데스메탈")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(DeathMetal);
            }
            else if(skill_name == "엔진 최대출력")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Engine);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Rage);
            }
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + EnemyCow.cowName + "은(는) 광폭 상태가 되었다!\n";
            if(!enemyCowRage.activeSelf)
            {
                enemyCowRage.SetActive(true);
                StatusActivity("rage", "EnemyCow", true);
            }
            enemyCowRageLeft.text = "<color=blue>6</color>";
        }
        else if(skill_name == "샤우팅" || skill_name == "우렁찬 울음소리")
        {
            int dmg = 500;
            if(skill_name == "우렁찬 울음소리") dmg = 1000;
            if(cowSteelization.activeSelf) dmg /= 2;
            if(skill_name == "샤우팅")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Shouting);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Elephant);
            }
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
            MyCow.nowHP -= dmg;
            if(cowRage.activeSelf)
            {
                cowRage.SetActive(false);
                StatusActivity("rage", "MyCow", false);
            }
            cowBalanced.SetActive(false);
            cowBalancedLeft.text = "<color=blue>0</color>";
            cowImmune.SetActive(false);
            cowImmuneLeft.text = "<color=blue>0</color>";
            cowSteelization.SetActive(false);
            cowSteelizationLeft.text = "<color=blue>0</color>";
            if(cowSuperSaiyan.activeSelf)
            {
                cowSuperSaiyan.SetActive(false);
                StatusActivity("superSaiyan", "MyCow", false);
            }
        }
        else if(skill_name == "균형잡기" || skill_name == "황야의 무법자")
        {
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + EnemyCow.cowName + "은(는) 균형 상태가 되었다!\n";
            enemyCowBlindLeft.text = "<color=red>0</color>";
            enemyCowBlind.SetActive(false);
            if(enemyCowOnFire.activeSelf)
            {
                enemyCowOnFireLeft.text = "<color=red>0</color>";
                enemyCowOnFire.SetActive(false);
                StatusActivity("onFire", "EnemyCow", false);
            }
            if(enemyCowSealed.activeSelf)
            {
                enemyCowSealedLeft.text = "<color=red>0</color>";
                enemyCowSealed.SetActive(false);
                StatusActivity("sealed", "EnemyCow", false);
            }
            enemyCowImmuneLeft.text = "<color=blue>6</color>";
            enemyCowImmune.SetActive(true);
            enemyCowBalancedLeft.text = "<color=blue>6</color>";
            enemyCowBalanced.SetActive(true);
        }
        else if(skill_name == "천벌" || skill_name == "썬더볼트")
        {
            int dmg = 500;
            if(skill_name == "썬더볼트") dmg = 1500;
            if(cowSteelization.activeSelf) dmg /= 2;
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Thunder);
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
            MyCow.nowHP -= dmg;
            if(!cowElectricShock.activeSelf && !cowImmune.activeSelf && !cowSuperSaiyan.activeSelf)
            {
                cowElectricShock.SetActive(true);
                StatusActivity("electricShock", "MyCow", true);
            }
            cowElectricShockLeft.text = "<color=red>2</color>";
        }
        else if(skill_name == "운기조식")
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Heal);
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=green>" + (EnemyCow.maxHP * 3 / 10) + "</color>의 체력을 회복!\n";
            EnemyCow.nowHP += (EnemyCow.maxHP * 3 / 10);
            if(EnemyCow.nowHP > EnemyCow.maxHP) EnemyCow.nowHP = EnemyCow.maxHP;
        }
        else if(skill_name == "총쏘기")
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
            if(enemyCowBlind.activeSelf)
            {
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 빗나갔다!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 하지만 " + MyCow.cowName + "은(는) 회피했다!\n";
                }
                else
                {
                    int dmg = 0;
                    if(EnemyCow.atkDmg * 5 - MyCow.armor > 0)
                    {
                        dmg = EnemyCow.atkDmg * 5 - MyCow.armor;
                    }
                    else
                    {
                        dmg = 0;
                    }
                    if(cowSteelization.activeSelf) dmg /= 2;
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=red>" + dmg + "</color>의 피해를 입었다!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "봉인")
        {
            int dmg = 2500;
            if(cowSteelization.activeSelf) dmg /= 2;
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Seal);
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "에게 <color=red>" + dmg + "</color>의 피해를 입혔다!\n";
            MyCow.nowHP -= dmg;
            if(!cowSealed.activeSelf && !enemyCowImmune.activeSelf && !enemyCowSuperSaiyan.activeSelf)
            {
                cowSealed.SetActive(true);
                StatusActivity("sealed", "MyCow", true);
            }
            cowSealedLeft.text = "<color=red>4</color>";
        }
        else if(skill_name == "뿔미사일")
        {
            int dmg = EnemyCow.atkDmg * 2 - MyCow.armor;
            if(EnemyCow.atkDmg * 2 - MyCow.armor > 0)
            {
                dmg = EnemyCow.atkDmg * 2 - MyCow.armor;
            }
            else
            {
                dmg = 0;
            }
            if(cowSteelization.activeSelf) dmg /= 2;
            AudioManager.GetComponent<AudioPlayer>().PlaySound(RocketLunch);
            yield return new WaitForSeconds(2f);
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Explosion);
            if(enemyCowBlind.activeSelf)
            {
                BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! 빗나갔지만 폭발에 의한 <color=red>" + dmg + "</color>의 데미지!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! " + MyCow.cowName + "은(는) 회피했지만 폭발에 의한 <color=red>" + dmg + "</color>의 데미지!\n";
                }
                else
                {
                    if(EnemyCow.atkDmg * 5 - MyCow.armor > 0)
                    {
                        dmg = EnemyCow.atkDmg * 5 - MyCow.armor;
                    }
                    else
                    {
                        dmg = 0;
                    }
                    if(cowSteelization.activeSelf) dmg /= 2;
                    BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "! <color=red>" + dmg + "</color>의 피해를 입었다!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "철과 같은 단단함")
        {
            BattleLog.text += EnemyCow.cowName + "의 " + skill_name + "!" + EnemyCow.cowName + "은(는) 단단해졌다!\n";
            enemyCowSteelizationLeft.text = "<color=blue>2</color>";
            enemyCowSteelization.SetActive(true);
        }
        else
        {
            Debug.Log("잘못된 skill_name!");
        }
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator Forkrain()
    {
        for(int i=0;i<10;i++)
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(ForkrainSound);
            yield return new WaitForSeconds(0.2f);
        }
    }

    public Image EnemyCowImage;
    public Sprite[] EnemyCowSprites;
    IEnumerator BattleWin()
    {
        Debug.Log("승리!");
        AudioManager.GetComponent<AudioPlayer>().PlayMusic(Fanfare, false);
        // cow status initialize
        MyCow.nowHP = MyCow.maxHP;
        MyCow.nowMP = MyCow.maxMP;
        cowBlind.SetActive(false);
        enemyCowBlind.SetActive(false);
        if(cowOnFire.activeSelf)
        {
            StatusActivity("onFire", "MyCow", false);
            cowOnFire.SetActive(false);
        }
        if(enemyCowOnFire.activeSelf)
        {
            StatusActivity("onFire", "EnemyCow", false);
            enemyCowOnFire.SetActive(false);
        }
        if(cowRage.activeSelf)
        {
            StatusActivity("rage", "MyCow", false);
            cowRage.SetActive(false);
        }
        if(enemyCowRage.activeSelf)
        {
            StatusActivity("rage", "EnemyCow", false);
            enemyCowRage.SetActive(false);
        }
        cowBalanced.SetActive(false);
        enemyCowBalanced.SetActive(false);
        cowImmune.SetActive(false);
        enemyCowImmune.SetActive(false);
        if(cowSealed.activeSelf)
        {
            StatusActivity("sealed", "MyCow", false);
            cowSealed.SetActive(false);
        }
        if(enemyCowSealed.activeSelf)
        {
            StatusActivity("sealed", "EnemyCow", false);
            enemyCowSealed.SetActive(false);
        }
        cowSteelization.SetActive(false);
        enemyCowSteelization.SetActive(false);
        if(cowSuperSaiyan.activeSelf)
        {
            StatusActivity("superSaiyan", "MyCow", false);
            cowSuperSaiyan.SetActive(false);
        }
        if(enemyCowSuperSaiyan.activeSelf)
        {
            StatusActivity("superSaiyan", "EnemyCow", false);
            enemyCowSuperSaiyan.SetActive(false);
        }
        if(cowElectricShock.activeSelf)
        {
            StatusActivity("electricShock", "MyCow", false);
        }

        // set EnemyCow
        if(EnemyCow.cowName == "젖소")
        {
            MilkCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("누렁이", 2000, 400, 50);
            dialogID = 1;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "누렁이")
        {
            YelloCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("우건마", 3000, 300, 100);
            dialogID = 2;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "우건마")
        {
            KangKeonCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("불판에서 뛰쳐나온 소", 4000, 500, 100);
            dialogID = 3;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "불판에서 뛰쳐나온 소")
        {
            BurningCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("미친소", 6000, 600, 200);
            dialogID = 4;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "미친소")
        {
            MadCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("롹커소", 8000, 800, 300);
            dialogID = 5;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "롹커소")
        {
            RockerCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("시소", 10000, 1000, 400);
            dialogID = 6;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "시소")
        {
            SeesawCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("조소", 12000, 1200, 700);
            dialogID = 7;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "조소")
        {
            WoodCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("카우보이소", 14000, 1400, 600);
            dialogID = 8;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "카우보이소")
        {
            CowboyCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("인도소", 16000, 1600, 700);
            dialogID = 9;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "인도소")
        {
            ElephantCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("마법'소'녀", 18000, 1800, 800);
            dialogID = 10;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
        else if(EnemyCow.cowName == "마법'소'녀")
        {
            JapaneseCowClear = true;
            WarningMessage.text = "승리!";
            EnemyCow.SetEnemyStatus("독일소", 20000, 2000, 1200);
            dialogID = 11;
            EnemyCowImage.sprite = EnemyCowSprites[dialogID];
        }
            // Debug.Log("클리어!");
            // SceneManager.LoadScene("EndingScene");
            // return;

        yield return new WaitForSeconds(0.5f);
    }
    public GameObject Cowshed;
    public GameObject BullFight;
    public GameObject TopMenuBar;
    public GameObject ToVillage;
    public GameObject To_Village;
    public void BattleOver()
    {
        AudioManager.GetComponent<AudioPlayer>().PlayMusic(TownTheme);
        ActionScript.intAction++;
        BattleLog.text = "";
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
        Cowshed.SetActive(true);
        BullFight.SetActive(false);
        TopMenuBar.SetActive(true);
    }

}

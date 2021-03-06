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
    public GameObject cowBlind, enemyCowBlind;
    public GameObject cowRage, enemyCowRage;
    public GameObject cowBalanced, enemyCowBalanced;
    public GameObject cowOnFire, enemyCowOnFire;
    public GameObject cowImmune, enemyCowImmune;
    public GameObject cowSealed, enemyCowSealed;
    public GameObject cowSteelization, enemyCowSteelization;
    public GameObject cowSuperSaiyan, enemyCowSuperSaiyan;
    public GameObject cowElectricShock;
    
    // Buff/Debuffs left turns
    public Text cowBlindLeft, enemyCowBlindLeft;
    public Text cowRageLeft, enemyCowRageLeft;
    public Text cowBalancedLeft, enemyCowBalancedLeft;
    public Text cowOnFireLeft, enemyCowOnFireLeft;
    public Text cowImmuneLeft, enemyCowImmuneLeft;
    public Text cowSealedLeft, enemyCowSealedLeft;
    public Text cowSteelizationLeft, enemyCowSteelizationLeft;
    public Text cowSuperSaiyanLeft, enemyCowSuperSaiyanLeft;
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
    public GameObject Skill3, Skill4, Skill5, Skill6, Skill7, Skill8, Skill9, Skill10, Skill11, Skill12, Skill13, Skill14, Skill15;
    public Button btnSkill1, btnSkill2, btnSkill3, btnSkill4, btnSkill5, btnSkill6, btnSkill7, btnSkill8, btnSkill9, btnSkill10, btnSkill11, btnSkill12, btnSkill13, btnSkill14, btnSkill15;
    public GameObject Skill1Blocked, Skill2Blocked, Skill3Blocked, Skill4Blocked, Skill5Blocked, Skill6Blocked, Skill7Blocked, Skill8Blocked, Skill9Blocked, Skill10Blocked;
    public GameObject Skill11Blocked, Skill12Blocked, Skill13Blocked, Skill14Blocked, Skill15Blocked;

    public ScrollRect scroll_rect;
    public void MouseOverToSkill(int skillID)
    {
        if(skillID == 0)
        {
            Skill_Name.text = "?????????";
            Mana_Required.text = "<color=blue>?????? 0</color>";
            Skill_Explanation.text = "????????? ?????? ????????? ?????????.";
        }
        else if(skillID == 1)
        {
            Skill_Name.text = "?????????";
            Mana_Required.text = "<color=blue>?????? 20</color>";
            Skill_Explanation.text = "????????? ???????????? ??? ????????? ?????????.";
        }
        else if(skillID == 2)
        {
            Skill_Name.text = "???????????????";
            Mana_Required.text = "<color=blue>?????? 0</color>";
            Skill_Explanation.text = "????????? ?????? ?????? ????????? ??????????????? ????????????, ????????? ????????? ?????? ????????????.";
        }
        else if(skillID == 3)
        {
            Skill_Name.text = "????????? ????????????";
            Mana_Required.text = "<color=blue>?????? 20</color>";
            Skill_Explanation.text = "????????? ????????? ????????? ????????? ?????? ????????????.";
        }
        else if(skillID == 4)
        {
            Skill_Name.text = "3?????????";
            Mana_Required.text = "<color=blue>?????? 30</color>";
            Skill_Explanation.text = "3???????????? 3??? ????????????.";
        }
        else if(skillID == 5)
        {
            Skill_Name.text = "?????????";
            Mana_Required.text = "<color=blue>?????? 40</color>";
            Skill_Explanation.text = "???????????? ???????????? ???????????? ????????? ??????????????? ?????????.";
        }
        else if(skillID == 6)
        {
            Skill_Name.text = "?????????????????? ?????????";
            Mana_Required.text = "<color=blue>?????? 30</color>";
            Skill_Explanation.text = "???????????? ??????. ?????? ????????? ????????????.";
        }
        else if(skillID == 7)
        {
            Skill_Name.text = "?????????";
            Mana_Required.text = "<color=blue>?????? 30</color>";
            Skill_Explanation.text = "????????? ??????????????? ???????????? ??????????????? ????????? ????????? ????????? ???????????????.";
        }
        else if(skillID == 8)
        {
            Skill_Name.text = "????????????";
            Mana_Required.text = "<color=blue>?????? 50</color>";
            Skill_Explanation.text = "????????? ?????? ????????? ????????? ????????? ??? ?????? ????????? ??????, ?????? ????????? ??????????????? ???????????? ??????????????? ??????.";
        }
        else if(skillID == 9)
        {
            Skill_Name.text = "????????????";
            Mana_Required.text = "<color=blue>?????? 0</color>";
            Skill_Explanation.text = "????????? ????????? ????????? ????????????.";
        }
        else if(skillID == 10)
        {
            Skill_Name.text = "?????????";
            Mana_Required.text = "<color=blue>?????? 50</color>";
            Skill_Explanation.text = "?????? ??????.";
        }
        else if(skillID == 11)
        {
            Skill_Name.text = "??????";
            Mana_Required.text = "<color=blue>?????? 80</color>";
            Skill_Explanation.text = "?????? ???????????? ??????????????? ????????? ???????????? ???????????? ???????????????.";
        }
        else if(skillID == 12)
        {
            Skill_Name.text = "?????? 20L ?????????";
            Mana_Required.text = "<color=blue>?????? 50</color>";
            Skill_Explanation.text = "????????? ???????????? ????????? ????????? ?????? ???????????? ?????? ????????? ??????????????? ????????????.";
        }
        else if(skillID == 13)
        {
            Skill_Name.text = "?????? ?????? ?????????";
            Mana_Required.text = "<color=blue>?????? 0</color>";
            Skill_Explanation.text = "????????? ????????? ?????? ??????????????? ????????? ???????????? ?????????.";
        }
        else if(skillID == 14)
        {
            Skill_Name.text = "???????????? ??????";
            Mana_Required.text = "<color=blue>?????? 100</color>";
            Skill_Explanation.text = "?????????????????? ????????? ?????? ????????? ??????????????? ???????????? ??????????????? ?????? ???????????? ???????????? ????????????.";
        }
        else if(skillID == 1000)
        {
            Skill_Name.text = "<color=red>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "?????? ????????? ?????? ??????????????? ?????? ??? ????????????.";
        }
        else if(skillID == 1001)
        {
            Skill_Name.text = "<color=blue>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "???????????? ???????????? ????????????.";
        }
        else if(skillID == 1002)
        {
            Skill_Name.text = "<color=blue>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "????????? ?????? ??????????????? ?????? ??? ??????.";
        }
        else if(skillID == 1003)
        {
            Skill_Name.text = "<color=red>?????????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "?????? ?????? ?????? ??????????????? ??????, ???????????? ????????????.";
        }
        else if(skillID == 1004)
        {
            Skill_Name.text = "<color=blue>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "????????? ??????????????? ????????? ?????????.";
        }
        else if(skillID == 1005)
        {
            Skill_Name.text = "<color=blue>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "???????????? ???????????? ????????????.";
        }
        else if(skillID == 1006)
        {
            Skill_Name.text = "<color=blue>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "?????? ????????? ??????????????????.";
        }
        else if(skillID == 1007)
        {
            Skill_Name.text = "<color=blue>????????????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "???????????? ???????????? ????????????, ????????? ??????????????? ????????? ?????????.";
        }
        else if(skillID == 1008)
        {
            Skill_Name.text = "<color=red>??????</color>";
            Mana_Required.text = "";
            Skill_Explanation.text = "??????????????? ????????? ??? ????????????.";
        }
        else
        {
            Skill_Explanation.text = "(??? ??? ??????)";
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
    public Text CowHPText, CowMPText, EnemyCowHPText;
    void Update()
    {
        Debug.Log(turn);
        Sprite[] itemSprites = GameManager.GetComponent<GameManager>().ItemSprites;
        CowHPText.text = "<color=red>" + MyCow.nowHP + "/" + MyCow.maxHP + "</color>";
        CowMPText.text = "<color=lime>" + MyCow.nowMP + "/" + MyCow.maxMP + "</color>";
        EnemyCowHPText.text = "<color=red>" + EnemyCow.nowHP + "/" + EnemyCow.maxHP + "</color>";
        if(dialogID == 1)
        {
            if(Input.anyKeyDown)
            {
                if(dialogIndex==0)
                {
                    WarningMessage.text = "?????? ?????? 3000?????? ????????????!";
                    Player.gold += 3000;
                } 
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '???????????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 3000?????? ????????????!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '????????? ????????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 3000?????? ????????????!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '3?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 3000?????? ????????????!";
                    Player.gold += 3000;
                }
                if(dialogIndex==1) 
                {
                    WarningMessage.text = "???????????? ?????? ???????????? ????????????!";
                    Player.Item item = new Player.Item();
                    item.itemName = "???????????? ?????? ?????????";
                    item.itemType = "??????";
                    item.itemPrice = 10000;
                    item.itemExplain = "???????????? ?????? ?????????";
                    item.itemSprite = itemSprites[7];
                    Player.inventory.Add(item);
                }
                if(dialogIndex==2) WarningMessage.text = MyCow.cowName + "???(???) ?????? '?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 5000?????? ????????????!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '?????????????????? ?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 5000?????? ????????????!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 5000?????? ????????????!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '????????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 5000?????? ????????????!";
                    Player.gold += 5000;
                }
                if(dialogIndex==1) 
                {
                    WarningMessage.text = "???????????? ?????? ???????????? ????????????!";
                    Player.Item item = new Player.Item();
                    item.itemName = "???????????? ?????? ?????????";
                    item.itemType = "??????";
                    item.itemPrice = 14000;
                    item.itemExplain = "???????????? ?????? ?????????";
                    item.itemSprite = itemSprites[8];
                    Player.inventory.Add(item);
                }
                if(dialogIndex==2) WarningMessage.text = MyCow.cowName + "???(???) ?????? '????????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 7000?????? ????????????!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 7000?????? ????????????!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '??????20L?????????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 7000?????? ????????????!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '??????'??? ?????????!";
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
                    WarningMessage.text = "?????? ?????? 7000?????? ????????????!";
                    Player.gold += 7000;
                }
                if(dialogIndex==1) WarningMessage.text = MyCow.cowName + "???(???) ?????? '?????? ?????? ?????????'??? ?????????!";
                if(dialogIndex==2) 
                {
                    WarningMessage.text = "???????????? ?????? ???????????? ????????????!";
                    Player.Item item = new Player.Item();
                    item.itemName = "???????????? ?????? ?????????";
                    item.itemType = "??????";
                    item.itemPrice = 20000;
                    item.itemExplain = "???????????? ?????? ?????????";
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
        turnText.text = "?????? ???!";

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
                StatusActivity("rage", "EnemyCow", false);
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
            if(EnemyCow.cowName == "??????")
            {
                enemyCowOnFireLeftInt += 2;
                BattleLog.text += "????????? ?????? ???????????????!\n";
            }
            enemyCowOnFireLeft.text = "<color=red>" + enemyCowOnFireLeftInt.ToString() + "</color>";
            int dmg = 50;
            if(EnemyCow.cowName == "??????") dmg *= 2;
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
                BattleLog.text += MyCow.cowName + "??? ?????????! ????????? ????????????!\n";
            }
            else
            {
                if(enemyCowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += MyCow.cowName + "??? ?????????! ?????????" + EnemyCow.cowName + "???(???) ????????????!\n";
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
                    BattleLog.text += MyCow.cowName + "??? ?????????!" + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 20;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += MyCow.cowName + "??? ?????????! ????????? ????????????!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                        BattleLog.text += MyCow.cowName + "??? ?????????! ?????????" + EnemyCow.cowName + "???(???) ????????????!\n";
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
                        BattleLog.text += MyCow.cowName + "??? ?????????! " + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
                        EnemyCow.nowHP -= dmg;
                    }
                }
                turnEnd = true;
            }
        }
        else if(skillID == 2)
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
            BattleLog.text += MyCow.cowName + "??? ???????????????! <color=green>" + (MyCow.maxHP / 10) + "</color>??? ????????? <color=blue>50</color>??? ????????? ??????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 20;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                    BattleLog.text += MyCow.cowName + "??? ????????????! ????????? ????????????!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                        BattleLog.text += MyCow.cowName + "??? ????????????! ?????????" + EnemyCow.cowName + "???(???) ????????????!\n";
                    }
                    else
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                        if(enemyCowImmune.activeSelf || enemyCowSuperSaiyan.activeSelf)
                        {
                            BattleLog.text += MyCow.cowName + "??? ????????????! ????????? " + EnemyCow.cowName + "???(???) ??????!\n";
                        }
                        else
                        {
                            BattleLog.text += MyCow.cowName + "??? ????????????! " + EnemyCow.cowName + "???(???) ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
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
                        BattleLog.text += MyCow.cowName + "??? 3?????????! ????????? ????????????!\n";
                    }
                    else
                    {
                        if(enemyCowBalanced.activeSelf)
                        {
                            AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                            yield return new WaitForSeconds(0.5f);
                            BattleLog.text += MyCow.cowName + "??? 3?????????! ?????????" + EnemyCow.cowName + "???(???) ????????????!\n";
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
                            BattleLog.text += MyCow.cowName + "??? 3?????????! " + EnemyCow.cowName + "?????? <color=red>" + dmg +"</color>??? ???????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 40;
                int dmg = 500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Fire);
                BattleLog.text += MyCow.cowName + "??? ?????????! " + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 30;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Rage);
                BattleLog.text += MyCow.cowName + "??? ?????????????????? ?????????! " + MyCow.cowName + "???(???) ?????? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 30;
                int dmg = 500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Shouting);
                BattleLog.text += MyCow.cowName + "??? ?????????! " + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
            }
            else
            {
                MyCow.nowMP -= 50;
                BattleLog.text += MyCow.cowName + "??? ????????????! " + MyCow.cowName + "???(???) ?????? ????????? ?????????!\n";
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
            BattleLog.text += MyCow.cowName + "??? ????????????! <color=blue>200</color>??? ????????? ??????!\n";
            MyCow.nowMP += 200;
            if(MyCow.nowMP > MyCow.maxMP) MyCow.nowMP = MyCow.maxMP;
            turnEnd = true;
        }
        else if(skillID == 10)
        {
            if(MyCow.nowMP < 50)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(WarningSound);
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 50;
                if(cowBlind.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
                    BattleLog.text += MyCow.cowName + "??? ?????????! ????????? ????????????!\n";
                }
                else
                {
                    if(enemyCowBalanced.activeSelf)
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
                        BattleLog.text += MyCow.cowName + "??? ?????????! ?????????" + EnemyCow.cowName + "???(???) ????????????!\n";
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
                        BattleLog.text += MyCow.cowName + "??? ?????????! " + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 80;
                int dmg = 2500;
                if(enemyCowSteelization.activeSelf) dmg /= 2;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Seal);
                BattleLog.text += MyCow.cowName + "??? ??????! " + EnemyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 50;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
                BattleLog.text += MyCow.cowName + "??? ?????? 20L ?????????! <color=green>" + (MyCow.maxHP * 3 / 10) + "</color>??? ????????? ??????!\n";
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
            BattleLog.text += MyCow.cowName + "??? ?????? ?????? ?????????!" + MyCow.cowName + "???(???) ???????????????!\n";
            cowSteelizationLeft.text = "<color=blue>2</color>";
            cowSteelization.SetActive(true);
            turnEnd = true;
        }
        else if(skillID == 14)
        {
            if(MyCow.nowMP < 100)
            {
                WarningMessage.text = "<color=blue>??????</color>??? ???????????????!";
            }
            else
            {
                MyCow.nowMP -= 100;
                AudioManager.GetComponent<AudioPlayer>().PlaySound(SuperSaiyanTransformation);
                BattleLog.text += MyCow.cowName + "??? ???????????? ??????!" + MyCow.cowName + "???(???) ??????????????? ?????????!\n";
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
            turnText.text = "????????? ???!";
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
        
        if(EnemyCow.cowName == "??????")
        {
            if(((float)EnemyCow.nowHP/(float)EnemyCow.maxHP) < 0.5f)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("???????????????"));
                }
            }
            else
            {
                StartCoroutine(EnemySkill("?????????"));
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if(!cowBalanced.activeSelf)
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("????????? ????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.2f)
            {
                StartCoroutine(EnemySkill("8?????????"));
            }
            else
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("3?????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
            }
        }
        else if(EnemyCow.cowName == "???????????? ???????????? ???")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(cowOnFire.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("???????????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,4);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("???????????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else if(r == 2)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                }
            }
            else
            {
                if(cowOnFire.activeSelf)
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if(enemyCowRage.activeSelf)
            {
                if(enemyCowBlind.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("???????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                }
            }
            else
            {
                StartCoroutine(EnemySkill("?????????????????? ?????????"));
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if(cowRage.activeSelf)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("???????????? ??????"));
                }
            }
            else
            {
                if(enemyCowRage.activeSelf)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("???????????? ??????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("???????????? ??????"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "??????")
        {
            if(enemyCowBalanced.activeSelf)
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("????????? ????????????"));
                }
            }
            else
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("?????????"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
            }
        }
        else if(EnemyCow.cowName == "??????")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("??????"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("???????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
            }
            else
            {
                if(enemyCowRage)
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("??????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("???????????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("??????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("???????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("????????? ??????"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "???????????????")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(enemyCowBalanced.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("??????????????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("??????????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("????????? ?????????"));
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
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("?????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("????????? ?????????"));
                    }
                }
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,4);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("????????? ????????????"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("???????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("?????? 20L ?????????"));
                }
            }
            else
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("????????? ????????????"));
                }
                else if(r == 1)
                {
                    StartCoroutine(EnemySkill("???????????????"));
                }
                else
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
            }
        }
        else if(EnemyCow.cowName == "??????'???'???")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.3f)
            {
                int r = Random.Range(0,2);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("??????"));
                }
                if(r == 1)
                {
                    StartCoroutine(EnemySkill("??????"));
                }
            }
            else
            {
                int r = Random.Range(0,3);
                if(r == 0)
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
                if(r == 1)
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
                if(r == 2)
                {
                    StartCoroutine(EnemySkill("????????????"));
                }
            }
        }
        else if(EnemyCow.cowName == "?????????")
        {
            if((float)EnemyCow.nowHP / (float)EnemyCow.maxHP < 0.5f)
            {
                if(enemyCowRage.activeSelf)
                {
                    int r = Random.Range(0,2);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("????????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????? ????????????"));
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
                        StartCoroutine(EnemySkill("??? ?????? ??????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("?????? ?????? ?????????"));
                    }
                }
                else
                {
                    int r = Random.Range(0,3);
                    if(r == 0)
                    {
                        StartCoroutine(EnemySkill("??? ?????? ??????"));
                    }
                    else if(r == 1)
                    {
                        StartCoroutine(EnemySkill("?????? ?????? ?????????"));
                    }
                    else
                    {
                        StartCoroutine(EnemySkill("?????? ????????????"));
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
        turnText.text = "?????? ???!";
        
    }

    IEnumerator EnemySkill(string skill_name)
    {
        if(skill_name == "?????????" || skill_name == "???????????????" || skill_name == "??? ?????? ??????")
        {
            if(enemyCowBlind.activeSelf)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? ????????????!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? " + MyCow.cowName + "???(???) ????????????!\n";
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
                    if(skill_name == "??? ?????? ??????")
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Chainsaw);
                    }
                    else
                    {
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(Hit);
                    }
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "???????????????" || skill_name == "?????? 20L ?????????" || skill_name == "??????")
        {
            if(skill_name == "??????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Heal);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Drinking);
            }
            if(skill_name == "???????????????")
            {
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=green>" + (EnemyCow.maxHP / 10) + "</color>??? ????????? ??????!\n";
                EnemyCow.nowHP += (EnemyCow.maxHP / 10);
            }
            else if(skill_name == "?????? 20L ?????????" || skill_name == "??????")
            {
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=green>" + (EnemyCow.maxHP * 3 / 10) + "</color>??? ????????? ??????!\n";
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
        else if(skill_name == "????????? ????????????")
        {
            if(enemyCowBlind.activeSelf)
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? ????????????!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ?????????" + MyCow.cowName + "???(???) ????????????!\n";
                }
                else
                {
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(KickManure);
                    if(cowImmune.activeSelf || cowSuperSaiyan.activeSelf)
                    {
                        BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? " + MyCow.cowName + "???(???) ??????!\n";
                    }
                    else
                    {
                        BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "???(???) ????????? ?????????!\n";
                        cowBlind.SetActive(true);
                        cowBlindLeft.text = "<color=red>4</color>";
                    }
                }
            }
        }
        else if(skill_name == "3?????????" || skill_name == "8?????????" || skill_name == "????????????")
        {
            int i=0;
            if(skill_name == "3?????????") i = 3;
            else if(skill_name == "8?????????") i = 8;
            else i = 2;
            for(int j = 0;j < i;j++)
            {
                if(enemyCowBlind.activeSelf)
                {
                    if(skill_name == "8?????????")
                    {
                        yield return new WaitForSeconds(0.2f);
                    }
                    else
                    {
                        yield return new WaitForSeconds(0.5f);
                    }
                    AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? ????????????!\n";
                }
                else
                {
                    if(cowBalanced.activeSelf)
                    {
                        if(skill_name == "8?????????")
                        {
                            yield return new WaitForSeconds(0.2f);
                        }
                        else
                        {
                            yield return new WaitForSeconds(0.5f);
                        }
                        AudioManager.GetComponent<AudioPlayer>().PlaySound(AvoidSound);
                        BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ?????????" + MyCow.cowName + "???(???) ????????????!\n";
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
                        if(skill_name == "8?????????")
                        {
                            yield return new WaitForSeconds(0.2f);
                        }
                        else
                        {
                            yield return new WaitForSeconds(0.5f);
                        }
                        BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "?????? <color=red>" + dmg +"</color>??? ???????????? ?????????!\n";
                        MyCow.nowHP -= dmg;
                    }
                }
            }
        }
        else if(skill_name == "?????????" || skill_name == "??????????????????" || skill_name == "????????????" || skill_name == "????????????")
        {
            int dmg = 300;
            if(skill_name == "??????????????????") dmg = 1000;
            if(skill_name == "????????????" || skill_name == "????????????") dmg = 1500;
            if(cowSteelization.activeSelf) dmg /= 2;
            if(skill_name == "??????????????????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Explosion);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Fire);
            }
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
            MyCow.nowHP -= dmg;
            if(!cowOnFire.activeSelf && !cowImmune.activeSelf && !cowSuperSaiyan.activeSelf)
            {
                cowOnFire.SetActive(true);
                StatusActivity("onFire", "MyCow", true);
            }
            cowOnFireLeft.text = "<color=red>4</color>";
        }
        else if(skill_name == "????????????" || skill_name == "???????????? ??????" || skill_name == "????????????")
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
            if(skill_name == "????????????")
            {
                StartCoroutine(Forkrain());
            }
            else if(skill_name == "???????????? ??????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(ElectricGuitar);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Earthquake);
            }
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
            MyCow.nowHP -= dmg;
        }
        else if(skill_name == "?????????????????? ?????????" || skill_name == "????????????" || skill_name == "????????? ??????" || skill_name == "?????? ????????????")
        {
            if(skill_name == "????????????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(DeathMetal);
            }
            else if(skill_name == "?????? ????????????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Engine);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Rage);
            }
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + EnemyCow.cowName + "???(???) ?????? ????????? ?????????!\n";
            if(!enemyCowRage.activeSelf)
            {
                enemyCowRage.SetActive(true);
                StatusActivity("rage", "EnemyCow", true);
            }
            enemyCowRageLeft.text = "<color=blue>6</color>";
        }
        else if(skill_name == "?????????" || skill_name == "????????? ????????????")
        {
            int dmg = 500;
            if(skill_name == "????????? ????????????") dmg = 1000;
            if(cowSteelization.activeSelf) dmg /= 2;
            if(skill_name == "?????????")
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Shouting);
            }
            else
            {
                AudioManager.GetComponent<AudioPlayer>().PlaySound(Elephant);
            }
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
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
        else if(skill_name == "????????????" || skill_name == "????????? ?????????")
        {
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + EnemyCow.cowName + "???(???) ?????? ????????? ?????????!\n";
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
        else if(skill_name == "??????" || skill_name == "????????????")
        {
            int dmg = 500;
            if(skill_name == "????????????") dmg = 1500;
            if(cowSteelization.activeSelf) dmg /= 2;
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Thunder);
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
            MyCow.nowHP -= dmg;
            if(!cowElectricShock.activeSelf && !cowImmune.activeSelf && !cowSuperSaiyan.activeSelf)
            {
                cowElectricShock.SetActive(true);
                StatusActivity("electricShock", "MyCow", true);
            }
            cowElectricShockLeft.text = "<color=red>2</color>";
        }
        else if(skill_name == "????????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Heal);
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=green>" + (EnemyCow.maxHP * 3 / 10) + "</color>??? ????????? ??????!\n";
            EnemyCow.nowHP += (EnemyCow.maxHP * 3 / 10);
            if(EnemyCow.nowHP > EnemyCow.maxHP) EnemyCow.nowHP = EnemyCow.maxHP;
        }
        else if(skill_name == "?????????")
        {
            AudioManager.GetComponent<AudioPlayer>().PlaySound(GunFire);
            if(enemyCowBlind.activeSelf)
            {
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? ????????????!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ????????? " + MyCow.cowName + "???(???) ????????????!\n";
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
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "??????")
        {
            int dmg = 2500;
            if(cowSteelization.activeSelf) dmg /= 2;
            AudioManager.GetComponent<AudioPlayer>().PlaySound(Seal);
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "?????? <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
            MyCow.nowHP -= dmg;
            if(!cowSealed.activeSelf && !enemyCowImmune.activeSelf && !enemyCowSuperSaiyan.activeSelf)
            {
                cowSealed.SetActive(true);
                StatusActivity("sealed", "MyCow", true);
            }
            cowSealedLeft.text = "<color=red>4</color>";
        }
        else if(skill_name == "????????????")
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
                BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! ??????????????? ????????? ?????? <color=red>" + dmg + "</color>??? ?????????!\n";
            }
            else
            {
                if(cowBalanced.activeSelf)
                {
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! " + MyCow.cowName + "???(???) ??????????????? ????????? ?????? <color=red>" + dmg + "</color>??? ?????????!\n";
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
                    BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "! <color=red>" + dmg + "</color>??? ????????? ?????????!\n";
                    MyCow.nowHP -= dmg;
                }
            }
        }
        else if(skill_name == "?????? ?????? ?????????")
        {
            BattleLog.text += EnemyCow.cowName + "??? " + skill_name + "!" + EnemyCow.cowName + "???(???) ???????????????!\n";
            enemyCowSteelizationLeft.text = "<color=blue>2</color>";
            enemyCowSteelization.SetActive(true);
        }
        else
        {
            Debug.Log("????????? skill_name!");
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
    public static int enemyCowSprite;
    IEnumerator BattleWin()
    {
        Debug.Log("??????!");
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
        if(EnemyCow.cowName == "??????")
        {
            MilkCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 2000, 400, 50);
            dialogID = 1;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "?????????")
        {
            YelloCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 3000, 300, 100);
            dialogID = 2;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "?????????")
        {
            KangKeonCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("???????????? ???????????? ???", 4000, 500, 100);
            dialogID = 3;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "???????????? ???????????? ???")
        {
            BurningCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 6000, 600, 200);
            dialogID = 4;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "?????????")
        {
            MadCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 8000, 800, 300);
            dialogID = 5;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "?????????")
        {
            RockerCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("??????", 10000, 1000, 400);
            dialogID = 6;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "??????")
        {
            SeesawCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("??????", 12000, 1200, 700);
            dialogID = 7;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "??????")
        {
            WoodCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("???????????????", 14000, 1400, 600);
            dialogID = 8;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "???????????????")
        {
            CowboyCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 16000, 1600, 700);
            dialogID = 9;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "?????????")
        {
            ElephantCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("??????'???'???", 18000, 1800, 800);
            dialogID = 10;
            enemyCowSprite = dialogID;
        }
        else if(EnemyCow.cowName == "??????'???'???")
        {
            JapaneseCowClear = true;
            WarningMessage.text = "??????!";
            EnemyCow.SetEnemyStatus("?????????", 20000, 2000, 1200);
            dialogID = 11;
            enemyCowSprite = dialogID;
        }
            // Debug.Log("?????????!");
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
        EnemyCowImage.sprite = EnemyCowSprites[enemyCowSprite];
        ActionScript.intAction++;
        BattleLog.text = "";
        ToVillage.SetActive(true);
        To_Village.SetActive(false);
        Cowshed.SetActive(true);
        BullFight.SetActive(false);
        TopMenuBar.SetActive(true);
    }

}

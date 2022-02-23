using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int gold = 2000;
    public class Item
    {
        public string itemName;
        public string itemType;
        public int itemPrice;
        public string itemExplain;
        // public Sprite itemImage;
        public int count = 1;
    }
    public static List<Item> inventory = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        Item item = new Item();
        item.itemName = "할아버지의 유품";
        item.itemType = "기타";
        item.itemPrice = 60000;
        item.itemExplain = "할아버지가 남긴 유품이자 집안의 가보이다. 비싸보인다.";
        inventory.Add(item);
    }

    public Text GoldText;
    public GameObject[] Slot;
    // Update is called once per frame
    void Update()
    {
        GoldText.text = gold.ToString();
        for(int i=0; i<Slot.Length; i++)
        {
            Slot[i].SetActive(i<inventory.Count);
            Text[] itemInfo = Slot[i].GetComponentsInChildren<Text>();
            Debug.Log(itemInfo.Length);
            itemInfo[0].text = i < inventory.Count ? inventory[i].itemName : "";
            itemInfo[1].text = i < inventory.Count ? inventory[i].count.ToString() : "";

        }
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    public GameObject ItemExplain;
    public RectTransform ItemExplainRect;
    public Text ItemExplainName;
    public Text ItemExplainType;
    public Text ItemExplainExplain;
    public void MouseOverToInventory(int slotNum)
    {
        ItemExplainName.text = inventory[slotNum].itemName;
        ItemExplainType.text = inventory[slotNum].itemType;
        ItemExplainExplain.text = inventory[slotNum].itemExplain;

        Vector2 mousePos = Input.mousePosition;
        ItemExplainRect.position = mousePos + new Vector2(ItemExplainRect.rect.width / 2, -ItemExplainRect.rect.height / 2);
        ItemExplain.SetActive(true);
    }
    public void MouseExitToInventory()
    {
        ItemExplain.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int gold = 2000;
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public string itemType;
        public int itemPrice;
        public string itemExplain;
        public Sprite itemSprite;
        public int count = 1;
        public bool isEquiped = false;
    }
    public static List<Item> inventory = new List<Item>();


    public Text GoldText;
    public GameObject[] Slot, IsEquiped;
    // Update is called once per frame
    void Update()
    {
        GoldText.text = gold.ToString();
        for(int i=0; i<Slot.Length; i++)
        {
            Slot[i].SetActive(i<inventory.Count);
            Text[] itemInfo = Slot[i].GetComponentsInChildren<Text>();
            Image itemImage = Slot[i].GetComponentInChildren<Image>();
            itemInfo[0].text = i < inventory.Count ? inventory[i].itemName : "";
            itemInfo[1].text = i < inventory.Count ? inventory[i].count.ToString() : "";
            itemImage.sprite = i < inventory.Count ? inventory[i].itemSprite : null;
            if(i < inventory.Count) IsEquiped[i].SetActive(Player.inventory[i].isEquiped);
        }
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

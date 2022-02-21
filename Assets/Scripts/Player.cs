using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int gold = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text GoldText;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(gold);
        GoldText.text = gold.ToString();
    }
}

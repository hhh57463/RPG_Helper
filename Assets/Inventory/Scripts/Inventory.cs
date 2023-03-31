using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ITEMTYPE
{
    EQUIP,
    CONSUM,
    ETC
}

[System.Serializable]
public struct TooltipObj
{
    public GameObject tooltip;
    public RawImage itemImg;
    public TextMeshProUGUI type;
    public TextMeshProUGUI name;
    public TextMeshProUGUI info;
}

public class Inventory : MonoBehaviour
{
    [System.Serializable]
    public class ItemsData
    {
        public string name;
        public string info;
        public int count;
        public string link;
    }

    [System.Serializable]
    public class ItemDataMng
    {
        public List<ItemsData> equipItem = new List<ItemsData>();
        public List<ItemsData> consumItem = new List<ItemsData>();
        public List<ItemsData> etcItem = new List<ItemsData>();
    }
    [SerializeField] TextAsset itemJson;
    public ItemDataMng itemDatas;
    [SerializeField] GameObject inventroy;
    [SerializeField] Transform inventoryViewer;
    [SerializeField] GameObject slotPrefab;
    public List<Slot> slots = new List<Slot>();
    [SerializeField] TooltipObj tooltipObj;
    void Start()
    {
        itemDatas = JsonUtility.FromJson<ItemDataMng>(itemJson.text);
        for (int i = 0; i < 50; i++)
        {
            slots.Add(Instantiate(slotPrefab, inventoryViewer).GetComponent<Slot>());
            slots[i].tooltipObj = tooltipObj;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventroy.SetActive(true);
            tooltipObj.tooltip.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            tooltipObj.tooltip.SetActive(false);
            inventroy.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class Slot : MonoBehaviour
{
    [SerializeField] RawImage btnImg;
    public ItemData data;
    public TooltipObj tooltipObj;
    public TextMeshProUGUI countText;

    void Awake()
    {
        btnImg = GetComponent<RawImage>();
    }

    void OnEnable()
    {
        StartCoroutine(GetTexture(btnImg));
    }
    
    public void ItemViewer()
    {
        tooltipObj.tooltip.SetActive(true);
        tooltipObj.tooltip.transform.position = Input.mousePosition;
        StartCoroutine(GetTexture(tooltipObj.itemImg));
        tooltipObj.name.text = data.itemName;
        switch (data.itemType)
        {
            case ITEMTYPE.EQUIP:
                tooltipObj.type.text = "Equip Item";
                break;
            case ITEMTYPE.CONSUM:
                tooltipObj.type.text = "Consum Item";
                break;
            case ITEMTYPE.ETC:
                tooltipObj.type.text = "ETC Item";
                break;
        }
        tooltipObj.info.text = data.info;
    }

    IEnumerator GetTexture(RawImage img)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(data.link);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            img.texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
    }

}

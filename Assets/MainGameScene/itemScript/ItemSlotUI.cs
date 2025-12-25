using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    //UI表示管理クラス
    public Button buyButton;//購入ボタン（今回は全部ボタンとして機能させます）
    public Image iconImage;//アイコン
    public TextMeshProUGUI description;
    public TextMeshProUGUI nameText;//商品名
    public TextMeshProUGUI priceText;//値段表示
    public TextMeshProUGUI stockText;//在庫表示

    ItemData itemData;
    ItemSystem itemSystem;

    public void Setup(ItemData data,ItemSystem system)
    {
        itemData = data;
        itemSystem = system;

        description.text = data.description;
        iconImage.sprite = data.itemIcon;
        nameText.text = data.itemName;
        priceText.text = $"MP:{data.price}";
        stockText.text = $"在庫：{data.stock}";

        buyButton.onClick.AddListener(OnClickBuy);

        UpdateUI();
    }

    public void OnClickBuy()
    {
        if (!itemSystem.CanBuy(itemData)) return;

        itemSystem.Buy(itemData);
        return;
    }

    void UpdateUI()
    {
        stockText.text = $"在庫：{itemData.stock}";
        buyButton.interactable = itemData.stock > 0;
    }
}

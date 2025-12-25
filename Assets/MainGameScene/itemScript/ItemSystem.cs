using UnityEngine;

public class ItemSystem : MonoBehaviour
{
    public int currentScore = 100;

    public bool CanBuy(ItemData item)
    {
        return item != null && currentScore >= item.price && item.stock > 0;
        //買うことが出来る状態を表す
    }

    public void Buy(ItemData item)
    {
        if (!CanBuy(item)) return;
        //

        currentScore -= item.price;
        item.stock--;

        GameParameter.Instance.ApplyItem(item);

        Debug.Log($"購入：{item.itemName} 残り在庫:{item.stock}");
    }
}

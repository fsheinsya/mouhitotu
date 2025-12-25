using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] ItemMasterData itemMaster;
    [SerializeField] GameObject shopItemPrefab;
    [SerializeField] Transform content;
    ItemSystem itemSystem;

   void Start()
    {
        Debug.Log("ShopManager Start", this);

        if(itemMaster == null)
        {
            Debug.LogError("ItemMaster Ç™ñ¢ê›íË", this);
            return;
        }

        foreach(var item in itemMaster.items)
        {
            if (item == null) continue;
            CreateItemUI(item);
        }
    }

    void CreateItemUI(ItemData item)
    {
        GameObject ui = Instantiate(shopItemPrefab, content);
        ui.GetComponent<ItemSlotUI>().Setup(item, itemSystem);
    }
}

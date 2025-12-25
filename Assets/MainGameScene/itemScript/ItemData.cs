using UnityEngine;

[CreateAssetMenu(
    fileName = "ItemData",
    menuName = "Scriptable Objects/Item"
)]
public class ItemData : ScriptableObject
{
    [Header("Šî–{î•ñ")]
    public string itemName;
    public Sprite itemIcon;
    public string description;
    public int price;
    public int stock;
    [Header("Œø‰Ê")]
    public float speedBonus;
    public int maxKeBonus;

    public void ReduceStock()
    {
        stock--;
    }
}

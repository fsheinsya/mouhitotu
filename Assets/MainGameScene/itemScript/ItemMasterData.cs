using UnityEngine;

[CreateAssetMenu(fileName = "ItemMasterData", menuName = "Scriptable Objects/ItemMasterData")]
public class ItemMasterData : ScriptableObject
{
    public ItemData[] items;
}

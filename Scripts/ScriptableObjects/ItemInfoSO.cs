using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "UnityInventory/Items/ItemInfoSO")]
public class ItemInfoSO : ScriptableObject {

    /// <summary>
    /// Sprite shown in the collectible item in the scene
    /// </summary>
    public Sprite itemSceneIcon;

    /// <summary>
    /// Sprite shown in the player's inventory
    /// </summary>
    public Sprite itemInventoryIcon;

    // More info
    public ItemTypes itemType;
    public int itemBuyPrice;
    public int itemSellPrice;
    public int itemAdditionalInfo;

}

public enum ItemTypes { Consumible, Armor, Weapon };

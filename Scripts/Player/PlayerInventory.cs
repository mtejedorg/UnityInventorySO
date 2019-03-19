using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

    private List<ItemInfoSO> itemsCollected;

    #region MonoBehaviour

    private void Start()
    {
        itemsCollected = new List<ItemInfoSO>();
    }

    #endregion

    #region Game Events

    public void OnItemCollected(object itemInfoObject)
    {
        ItemInfoSO itemInfo = (ItemInfoSO)itemInfoObject;
        if(itemInfo != null)
        {
            itemsCollected.Add(itemInfo);
        }
    }

    #endregion
}

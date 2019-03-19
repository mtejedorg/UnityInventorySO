using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public GameEvent itemCollectedEvent;

    public ItemInfoSO itemInfo;

    private void OnEnable()
    {
        GetComponent<SpriteRenderer>().sprite = itemInfo.itemSceneIcon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            itemCollectedEvent.Raise(itemInfo);
            Destroy(this.gameObject);
        }
    }
}

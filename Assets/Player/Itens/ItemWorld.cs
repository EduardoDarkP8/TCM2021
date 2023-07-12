using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    public static ItemWorld SpawnItemWorld(Vector3 position ,Item item)
    {
        Transform transform = Instantiate(ItemAsset.Instance.pfItemWorld, position, Quaternion.identity);
        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);
        return itemWorld;
    }
    private Item item;
    private MeshFilter meshFilter;
    private BoxCollider colider;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
        colider = GetComponent<BoxCollider>();
    }

    public void SetItem(Item item) 
    {
        this.item = item;
        meshFilter.mesh = item.GetModel();
        colider.center = item.GetCenter();
        colider.size = item.GetSize();
    }
    public void DestroySelf() 
    {
        Destroy(gameObject);
    }
    public Item GetItem() 
    {
        return item;
    }
    public Item.ItemTypes getType() 
    {
        return item.itemType;
    }
}

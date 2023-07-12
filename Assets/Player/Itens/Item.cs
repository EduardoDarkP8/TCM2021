using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemTypes 
    {
        Crowbar,
        FlashLight,
        Box,
        Key1,
        Key2,
        Tape1,
        Tape2,
        Tape3,
        Paper1,
        Paper2,
        Paper3,
        Pistol,
    }
    public ItemTypes itemType;
    public int amount;

    public Sprite GetSprite() 
    {
        switch(itemType)
        {
            default:
            case ItemTypes.Crowbar: return ItemAsset.Instance.CrowbarSp;
            case ItemTypes.FlashLight: return ItemAsset.Instance.FlashLightSp;
            case ItemTypes.Box: return ItemAsset.Instance.BoxSp;
            case ItemTypes.Key1: return ItemAsset.Instance.Key1Sp;
            case ItemTypes.Key2: return ItemAsset.Instance.Key2Sp;
            case ItemTypes.Tape1: return ItemAsset.Instance.Tape1Sp;
            case ItemTypes.Tape2: return ItemAsset.Instance.Tape2Sp;
            case ItemTypes.Tape3: return ItemAsset.Instance.Tape3Sp;
            case ItemTypes.Paper1: return ItemAsset.Instance.Paper1Sp;
            case ItemTypes.Paper2: return ItemAsset.Instance.Paper2Sp;
            case ItemTypes.Paper3: return ItemAsset.Instance.Paper3Sp;
            case ItemTypes.Pistol: return ItemAsset.Instance.PistolSp;
        }
    }
    public Mesh GetModel() 
    {
        switch (itemType)
        {
            default:
            case ItemTypes.Crowbar: return ItemAsset.Instance.CrowbarMp;
            case ItemTypes.FlashLight: return ItemAsset.Instance.FlashLightMp;
            case ItemTypes.Box: return ItemAsset.Instance.BoxMp;
            case ItemTypes.Key1: return ItemAsset.Instance.Key1Mp;
            case ItemTypes.Key2: return ItemAsset.Instance.Key2Mp;
            case ItemTypes.Tape1: return ItemAsset.Instance.Tape1Mp;
            case ItemTypes.Tape2: return ItemAsset.Instance.Tape2Mp;
            case ItemTypes.Tape3: return ItemAsset.Instance.Tape3Mp;
            case ItemTypes.Paper1: return ItemAsset.Instance.Paper1Mp;
            case ItemTypes.Paper2: return ItemAsset.Instance.Paper2Mp;
            case ItemTypes.Paper3: return ItemAsset.Instance.Paper3Mp;
            case ItemTypes.Pistol: return ItemAsset.Instance.PistolMp;
        }
    }
    public Vector3 GetCenter()
    {
        switch (itemType)
        {
            default:
            case ItemTypes.Crowbar: return new Vector3(-0.85f, 2.6f, 0);
            case ItemTypes.FlashLight: return new Vector3();
            case ItemTypes.Box: return new Vector3();
            case ItemTypes.Key1: return new Vector3();
            case ItemTypes.Key2: return new Vector3();
            case ItemTypes.Tape1: return new Vector3();
            case ItemTypes.Tape2: return new Vector3();
            case ItemTypes.Tape3: return new Vector3();
            case ItemTypes.Paper1: return new Vector3();
            case ItemTypes.Paper2: return new Vector3();
            case ItemTypes.Paper3: return new Vector3();
            case ItemTypes.Pistol: return new Vector3();
        }
    }
    public Vector3 GetSize()
    {
        switch (itemType)
        {
            default:
            case ItemTypes.Crowbar: return new Vector3(0.6f, 1,3);
            case ItemTypes.FlashLight: return new Vector3();
            case ItemTypes.Box: return new Vector3();
            case ItemTypes.Key1: return new Vector3();
            case ItemTypes.Key2: return new Vector3();
            case ItemTypes.Tape1: return new Vector3();
            case ItemTypes.Tape2: return new Vector3();
            case ItemTypes.Tape3: return new Vector3();
            case ItemTypes.Paper1: return new Vector3();
            case ItemTypes.Paper2: return new Vector3();
            case ItemTypes.Paper3: return new Vector3();
            case ItemTypes.Pistol: return new Vector3();
        }
    }
}

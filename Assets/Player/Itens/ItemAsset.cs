using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAsset : MonoBehaviour
{
    public static ItemAsset Instance { get; private set; }
    private void Awake()
    {
        Instance = this;

    }
    public Transform pfItemWorld;
    public Sprite CrowbarSp;
    public Sprite FlashLightSp;
    public Sprite BoxSp;
    public Sprite Key1Sp;
    public Sprite Key2Sp;
    public Sprite Tape1Sp;
    public Sprite Tape2Sp;
    public Sprite Tape3Sp;
    public Sprite Paper1Sp;
    public Sprite Paper2Sp;
    public Sprite Paper3Sp;
    public Sprite PistolSp;
    public Mesh CrowbarMp;
    public Mesh FlashLightMp;
    public Mesh BoxMp;
    public Mesh Key1Mp;
    public Mesh Key2Mp;
    public Mesh Tape1Mp;
    public Mesh Tape2Mp;
    public Mesh Tape3Mp;
    public Mesh Paper1Mp;
    public Mesh Paper2Mp;
    public Mesh Paper3Mp;
    public Mesh PistolMp;
}

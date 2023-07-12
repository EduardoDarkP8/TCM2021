using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_InventoryScript Ui_inventory;
    [SerializeField] private GameObject flashligt;
    [SerializeField] private GameObject Obj;
    private bool camera = true;
    private bool invetory = false;
    public static bool dead = false;


    private void Awake()
    {
        inventory = new Inventory();
   


    }
    private void Start()
    {
        ItemWorld.SpawnItemWorld(new Vector3(119.92f, 119.92f, 119.92f), new Item { itemType = Item.ItemTypes.Crowbar, amount = 1 });
        Obj.SetActive(false);
        invetory = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            if (itemWorld.getType() == Item.ItemTypes.FlashLight) { UI_InventoryScript.Lanterna = true; }
            if (itemWorld.getType() == Item.ItemTypes.Crowbar) { UI_InventoryScript.PedeCabra = true; }
            if (itemWorld.getType() == Item.ItemTypes.Box) { UI_InventoryScript.CaixaSupresa = true; }
            if (itemWorld.getType() == Item.ItemTypes.Key1) { UI_InventoryScript.Chave1 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Key2) { UI_InventoryScript.Chave2 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Tape1) { UI_InventoryScript.Fita1 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Tape2) { UI_InventoryScript.Fita2 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Paper1) { UI_InventoryScript.Papel1 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Paper2) { UI_InventoryScript.Papel2 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Paper3) { UI_InventoryScript.Papel3 = true; }
            if (itemWorld.getType() == Item.ItemTypes.Pistol) { UI_InventoryScript.Pistola = true; }
            itemWorld.DestroySelf();


        }
        FilhoSumiu filho = collider.GetComponent<FilhoSumiu>();
        if (filho != null)
		{
            filho.Porta();
            filho.FrenteDaFloresta();
		}
        Sequestro sequestro = collider.GetComponent<Sequestro>();
        if(sequestro != null)
		{
            sequestro.SpawnGhost();
            sequestro.SumirFilho();
		}
        OpenLevel2 opn = collider.GetComponent<OpenLevel2>();
        if(opn != null)
		{
            opn.OpenForest();
		}
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && camera == true)
        {
            flashligt.SetActive(false);
            camera = false;

        }
        else if (Input.GetKeyDown(KeyCode.F) && camera == false)
        {
            flashligt.SetActive(true);
            camera = true;
        }

        if (Input.GetKeyDown(KeyCode.Tab) && invetory == false)
        {
            Obj.SetActive(true);
            invetory = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && invetory == true)
        {
            Obj.SetActive(false);
            invetory = false;
        }
    }

}

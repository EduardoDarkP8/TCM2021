using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InventoryScript : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemSlotLanterna;
    public GameObject itemSlotPedeCabra;
    public GameObject itemSlotCaixaSurpresa;
    public GameObject itemSlotChave1;
    public GameObject itemSlotChave2;
    public GameObject itemSlotFita1;
    public GameObject itemSlotFita2;
    public GameObject itemSlotPapel1;
    public GameObject itemSlotPapel2;
    public GameObject itemSlotPapel3;
    public GameObject itemSlotPistola;
    public static bool Lanterna = true;
    public static bool PedeCabra = false;
    public static bool CaixaSupresa = false;
    public static bool Chave1 = false;
    public static bool Chave2 = false;
    public static bool Fita1 = false;
    public static bool Fita2 = false;
    public static bool Papel1 = false;
    public static bool Papel2 = false;
    public static bool Papel3 = false;
    public static bool Pistola = false;
	private void FixedUpdate()
	{
		if (Lanterna) { itemSlotLanterna.SetActive(true); }
        if (PedeCabra) { itemSlotPedeCabra.SetActive(true); }
        if (CaixaSupresa) { itemSlotCaixaSurpresa.SetActive(true); }
        if (Chave1) { itemSlotChave1.SetActive(true); }
        if (Chave2) { itemSlotChave2.SetActive(true); }
        if (Fita1) { itemSlotFita1.SetActive(true); }
        if (Fita2) { itemSlotFita2.SetActive(true); }
        if (Papel1) { itemSlotPapel1.SetActive(true); }
        if (Papel2) { itemSlotPapel2.SetActive(true); }
        if (Papel3) { itemSlotPapel3.SetActive(true); }
        if (Pistola) { itemSlotPistola.SetActive(true); }
    }

}

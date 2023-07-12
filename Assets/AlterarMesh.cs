using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterarMesh : MonoBehaviour
{
	public Mesh OriginalMesh;
	public Mesh OpenedMesh;
	public MeshFilter obj;
	public bool HaveItem;
	public Vector3 itemPos;
	public Item item;


    private void Awake()
    {
		obj.mesh = OriginalMesh;



    }
	public void TurnIt(AlterarMesh gmObj) 
	{
		if (gmObj.HaveItem) 
		{
			ItemWorld.SpawnItemWorld(gmObj.itemPos, gmObj.item);
		}
		obj.mesh = OpenedMesh;
	}
}

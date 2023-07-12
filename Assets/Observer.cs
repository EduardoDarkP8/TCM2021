using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform observerLocal;
    public GameObject observerObj;
    public Transform player;
    public static bool CleanAll;

	private void FixedUpdate()
	{
        Vector3 relativePos = (player.position - observerLocal.position);
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        DestroyIstantis();
        Quaternion.LookRotation(player.position);
    }

    private void DestroyIstantis() 
    {
		if (CleanAll) 
        {
            Destroy(observerObj);
        }
    }

}

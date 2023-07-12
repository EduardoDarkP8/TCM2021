using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morrer : MonoBehaviour
{
    public GameObject Dead;
    public GameObject Retry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.dead == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = Cursor.visible;

            Dead.SetActive(true);
            Retry.SetActive(true);
        }
    }
}

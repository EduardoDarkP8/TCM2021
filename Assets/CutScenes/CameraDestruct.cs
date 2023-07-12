using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDestruct : MonoBehaviour
{
    public GameObject Cut;
    public GameObject Player;
    public GameObject Canvas;
    public GameObject Filho;
    public void destroyCameraInicial() 
    {
        Destroy(Cut);
        Player.SetActive(true);
        Filho.SetActive(true);
    }
	private void Start()
	{
        Canvas.SetActive(false);

	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	public int Cena;
	public void retry() 
	{
		SceneManager.LoadScene(Cena);
	} 
}

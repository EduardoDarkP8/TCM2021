using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FilhoSumiu : MonoBehaviour
{
	public Collider EntrenceArea;
	public GameObject Dark;
	public GameObject Player;
	public GameObject Filho;
	public GameObject JumpScare;
	public Animator animator;

	public void Porta() 
	{
		Dark.SetActive(true);
		EntrenceArea.enabled = false;
		Filho.transform.position = new Vector3(-128.2f,240.79f, 110.9862f);
		JumpScare.SetActive(true);

	}
	public void FrenteDaFloresta() 
	{
		animator.SetBool("CutScene1", true);
	}




}

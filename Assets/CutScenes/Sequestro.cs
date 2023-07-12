using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Sequestro : MonoBehaviour
{
    public GameObject Phantom1;
    public GameObject Phantom2;
    public GameObject Phantom3;
    public GameObject filho;
    public Animator animator;
    public void SpawnGhost()
	{
        Phantom1.SetActive(true);
        Phantom2.SetActive(true);
        Phantom3.SetActive(true);
        Destroy(Phantom1, 0.5f);
        Destroy(Phantom2, 0.5f);
        Destroy(Phantom3, 0.5f);

    }
    public void SumirFilho()
	{
        animator.SetBool("CutScene2", true);

	}

}

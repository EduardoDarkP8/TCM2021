using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEnd : MonoBehaviour
{
    public GameObject porta;
    Observer obs;
    public GameObject Next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.enabled == true)
		{
            Next.SetActive(true);
            Destroy(gameObject, 0.5f);
            Destroy(porta, 0.5f);

		}
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float currenTime = 0f;
    public float startingTime = 10f;
    float Down = 1;
    Text timer;
    public GameObject Dead;
    public GameObject Retry;
    void Start()
    {
        timer = gameObject.GetComponent<Text>();
        currenTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currenTime -= 1 * Time.deltaTime;
        timer.text = "Sanidade: " + currenTime.ToString("0");
        if(currenTime <= 0) 
        {
            currenTime = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = Cursor.visible;
            Player.dead = true;
            Dead.SetActive(true);
            Retry.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float Xaxis, Yaxis;
    public float MouseSens = 100f;
    public Transform body;
    float RotatX = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        locking();
    }
    public void locking()
    {

        Xaxis = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        Yaxis = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;
        RotatX -= Yaxis;
        RotatX = Mathf.Clamp(RotatX, -90f, 90f);
        body.Rotate(Vector3.up * Xaxis);
        transform.localRotation = Quaternion.Euler(RotatX,0f,0f);
    }

}

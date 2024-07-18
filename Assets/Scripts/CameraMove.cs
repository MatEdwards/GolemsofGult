using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraMove : MonoBehaviour
{
    private int edgeScrollSize = Screen.width / 50;
    [SerializeField] private float rotateSpeed = 0.40f;
    private const float rotationLimit = 45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateDir = 0f;
        if (Input.mousePosition.x < edgeScrollSize) rotateDir = -1f;
        if (Input.mousePosition.x > Screen.width - edgeScrollSize) rotateDir = +1f;
        
        //Rotate stop points
        var yRotation = transform.eulerAngles.y;
        
        if (yRotation is >= rotationLimit and < 180) rotateDir = Math.Min(0, rotateDir);
        if (yRotation is <= 360 - rotationLimit and > 180) rotateDir = Math.Max(0, rotateDir);

        transform.eulerAngles += new Vector3(0, rotateDir * rotateSpeed, 0);
    }
}

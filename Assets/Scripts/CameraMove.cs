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
    
    [SerializeField] private Texture2D handRight;
    [SerializeField] private Texture2D handLeft;
    [SerializeField] private Texture2D handDefault;
    private bool turning = false;

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
        
        //Manage cursor icon
        if (rotateDir > 0)
        {
            Cursor.SetCursor( handRight, new Vector2(handRight.width / 2,handRight.height / 2), CursorMode.Auto);
            turning = true;
        } else if (rotateDir < 0)
        {
            Cursor.SetCursor( handLeft, new Vector2(handLeft.width / 2,handLeft.height / 2), CursorMode.Auto);
            turning = true;
        }
        else if (turning)
        {
            turning = false;
            Cursor.SetCursor( handDefault, new Vector2(0,0), CursorMode.Auto);
        }

        transform.eulerAngles += new Vector3(0, rotateDir * rotateSpeed, 0);
    }
}

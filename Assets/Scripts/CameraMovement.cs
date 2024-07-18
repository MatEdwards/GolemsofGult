using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float Depth;

    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Depth);
        Vector3 mosueDirection = Camera.main.ScreenToWorldPoint(mousePosition);

        Debug.Log("Mouse position:" + mousePosition + "\nMouse Direction: " + mosueDirection);
    }
}

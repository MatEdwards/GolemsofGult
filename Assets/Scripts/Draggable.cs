using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Draggable : MonoBehaviour
{
    Rigidbody rb;
    private Vector3 startingPos; 
    private float depth = 4;

    [SerializeField] private Texture2D handClosed;
    [SerializeField] private Texture2D handOver;
    [SerializeField] private Texture2D handDefault;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseOver()
    {
        Cursor.SetCursor( handOver, new Vector2(handOver.width / 2,handOver.height / 2), CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor( handDefault, new Vector2(0,0), CursorMode.Auto);
    }

    private void OnMouseDrag()
    {
        
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,depth);
        Vector3 mouseDirection = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = mouseDirection;
        
        Cursor.SetCursor( handClosed, new Vector2(handClosed.width / 2,handClosed.height / 2), CursorMode.Auto);
        rb.isKinematic = true;
    }
    private void OnMouseUp()
    {
        Cursor.SetCursor( handDefault, new Vector2(0,0), CursorMode.Auto);
        rb.isKinematic = false;
    }
    
}

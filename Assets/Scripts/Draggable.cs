using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Draggable : MonoBehaviour
{
    Rigidbody rb;
    private Vector3 startingPos; 
    private float depth = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        //Vector3 startingPos = transform.position;
    }

    private void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,depth);

        Vector3 mouseDirection = Camera.main.ScreenToWorldPoint(mousePosition);
        
        transform.position = mouseDirection;
        
        rb.isKinematic = true;
    }
    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
    
}

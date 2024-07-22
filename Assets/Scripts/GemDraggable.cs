using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDraggable : MonoBehaviour
{
    Rigidbody rb;
    Vector3 startingPos;
    float depth = 4f;
    bool isBeingDragged = false;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        OnMouseDown();
    }

    void Update()
    {
        if (isBeingDragged)
            FollowCursor();

        if (Input.GetMouseButtonUp(0))
            ReleaseObject();
    }

    void FollowCursor()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,depth);
        Vector3 mouseDirection = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = mouseDirection;
    }

    void OnMouseDown()
    {
        isBeingDragged = true;
        rb.isKinematic = true;
        Debug.Log("Mouse Down");
    }

    void ReleaseObject()
    {
        rb.isKinematic = false;
        isBeingDragged = false;
        Debug.Log("Mouse Up");
    }
}

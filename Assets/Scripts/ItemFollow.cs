using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ItemFollow : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        Vector3 mosueDirection = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = mosueDirection;
    }
}

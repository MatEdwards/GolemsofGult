using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    [SerializeField]
    GameObject Item;

    void OnMouseDown()
    {
        Debug.Log("Spawned Item");

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f);
        Vector3 mouseDirection = Camera.main.ScreenToWorldPoint(mousePosition);

        Instantiate(Item, mouseDirection, transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;
    public float speed;
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get coordinates of mouse position in game


        if (Input.GetMouseButtonDown(1))
        {
            target = new Vector2(mousePos.x, mousePos.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
}

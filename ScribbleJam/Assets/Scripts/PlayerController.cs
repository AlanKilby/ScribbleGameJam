using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;

    bool canMove;

    public float speed;
    float speedHolder;
    private void Start()
    {
        speedHolder = speed;
    }
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get coordinates of mouse position in game


        if (Input.GetMouseButtonDown(1))
        {
            canMove = true;
            speed = speedHolder;
            target = new Vector2(mousePos.x, mousePos.y);
        }

        if(canMove)
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            canMove = false;
            speed = 0;
        }
    }


}

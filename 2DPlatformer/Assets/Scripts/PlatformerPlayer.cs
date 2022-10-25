using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayer : MonoBehaviour
{
    public float speed = 250f;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, _rb.velocity.y);
        _rb.velocity = movement;
    }
}

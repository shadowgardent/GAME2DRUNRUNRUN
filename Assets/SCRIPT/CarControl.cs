using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed  = 1f;
    public float minspeed = 8f;
    public float maxspeed = 12f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        speed = Random.Range(minspeed,maxspeed);
    }

   
    void Update()
    {
        Vector2 forword = new Vector2 (transform.right.x,transform.right.y);
        rb.MovePosition(rb.position + forword * Time.deltaTime * speed);
    }
}

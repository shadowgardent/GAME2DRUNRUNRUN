using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float screenLeft;
    private float screenRight;
    private float screenTop;
    private float screenBottom;

    void Start()
    {
        // กำหนดขอบเขตของหน้าจอ
        Camera cam = Camera.main;
        screenLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane)).x;
        screenRight = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.nearClipPlane)).x;
        screenTop = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.nearClipPlane)).y;
        screenBottom = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.nearClipPlane)).y;
    }

    private void Update()
    {
        // ตรวจสอบว่ากระสุนออกจากขอบหน้าจอหรือยัง
        if (transform.position.x < screenLeft || transform.position.x > screenRight ||
            transform.position.y < screenBottom || transform.position.y > screenTop)
        {
            Destroy(gameObject); // ทำลายกระสุนถ้าออกนอกขอบเขตหน้าจอ
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            // ทำลายรถเมื่อกระสุนชน
            Destroy(collision.gameObject);
            Destroy(gameObject); // ทำลายกระสุนเองด้วย
        }
        else if (collision.gameObject.tag == "wall")
        {
            // ทำลายกระสุนเมื่อชนกับกำแพง
            Destroy(gameObject);
        }
    }
}



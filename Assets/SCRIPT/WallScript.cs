using UnityEngine;

public class WallScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ตรวจสอบว่ากระสุนชนกำแพงหรือไม่
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject); // ทำลายกระสุนเมื่อชนกำแพง
        }
    }
}

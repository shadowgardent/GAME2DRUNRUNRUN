using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public float moveSpeed = 5f;  // ความเร็วในการเดิน

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // การเคลื่อนที่
        rb.velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);

        // ตั้งค่าอนิเมชันเมื่อมีการเดิน
        if (moveX != 0 || moveY != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false); // หากไม่มีการกดปุ่ม ให้อนิเมชัน Idle ทำงาน
        }

    
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Car")
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           PlayerDied();
        }
    }
        public void PlayerDied()
    {
        SceneManager.LoadScene("SampleSceneLevel1"); // โหลดกลับไปยังซีน 1 เสมอเมื่อผู้เล่นตาย
    }

    
}

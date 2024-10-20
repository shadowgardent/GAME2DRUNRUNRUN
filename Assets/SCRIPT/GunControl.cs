using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab ของลูกกระสุน
    public Transform firePoint;      // จุดที่ลูกกระสุนจะถูกยิงออกไป
    public float bulletSpeed = 10f;  // ความเร็วของลูกกระสุน

    void Update()
    {
        // ตรวจสอบการยิงลูกกระสุน
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // สร้างลูกกระสุนใหม่จาก Prefab
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // เพิ่มความเร็วให้ลูกกระสุน
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = firePoint.right * bulletSpeed;  // ยิงไปข้างหน้า
    }
}
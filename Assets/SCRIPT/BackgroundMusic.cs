using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;
    private AudioSource audioSource;

    void Awake()
    {
        // ตรวจสอบว่ามี instance ของ BackgroundMusic อยู่แล้วหรือไม่
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // ป้องกันไม่ให้ BackgroundMusic ถูกทำลายเมื่อเปลี่ยนซีน
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject); // หากมีอยู่แล้วก็ทำลายตัวใหม่ทิ้ง
        }
    }

    void Update()
    {
        // ตรวจสอบชื่อซีนปัจจุบัน
        string currentScene = SceneManager.GetActiveScene().name;

        // หากซีนปัจจุบันคือ EndScene (ซีนสุดท้ายที่มีวิดีโอ) ให้หยุดเพลง
        if (currentScene == "SampleSceneEND")
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
        else
        {
            // ถ้าไม่ใช่ซีนสุดท้าย ให้แน่ใจว่าเพลงกำลังเล่นอยู่
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}

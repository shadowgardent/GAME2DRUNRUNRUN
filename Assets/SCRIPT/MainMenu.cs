using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // ฟังก์ชันนี้จะถูกเรียกเมื่อกดปุ่ม "Start Game"
    public void StartGame()
    {
        SceneManager.LoadScene("SampleSceneLevel1"); // 
    }

    // ฟังก์ชันสำหรับออกจากเกม (หากต้องการ)
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); // ใช้ได้เฉพาะตอน Build เกม
    }
}

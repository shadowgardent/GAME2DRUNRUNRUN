using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int score ; 
    public Text scoreText;

    private GameObject flogPlayer;
    private Vector3 playerStartPos = new Vector3(-0.26f, -5f, 0);
    public int maxScore = 3;

  private void Start()  // ใช้ Start แทน Awake
    {
        flogPlayer = GameObject.FindGameObjectWithTag("Player");
    }

   private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Player")
        {
           
           target.transform.position = playerStartPos;
           score += 1 ;
           scoreText.text = score.ToString();
   
        }
        if (score >= maxScore)
            {
                ChangeScene();
            }
        
    }
    private void ChangeScene()
    {
        // ตรวจสอบว่าซีนปัจจุบันคืออะไร แล้วโหลดซีนถัดไป
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "SampleSceneLevel1")
        {
            SceneManager.LoadScene("SampleSceneLevel2");
        }
        else if (currentScene == "SampleSceneLevel2")
        {
            SceneManager.LoadScene("SampleSceneLevel3");
        }
        else if (currentScene == "SampleSceneLevel3")
        {
            SceneManager.LoadScene("SampleSceneEND");
            Debug.Log("You have completed the game!");
            //เพิ่มโค้ดจบเกมหรือรีเซ็ตเกมที่นี่
        }
    }
 
}


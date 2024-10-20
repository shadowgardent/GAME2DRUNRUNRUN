using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int score; 
    public Text scoreText;

    private GameObject flogPlayer;
    private Vector3 playerStartPos = new Vector3(-0.26f, -5f, 0);
    public int maxScore = 3;

    private void Start()
    {
        flogPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            target.transform.position = playerStartPos;
            score += 1;
            scoreText.text = score.ToString(); // ใช้ text แทน Text

            if (score >= maxScore)
            {
                ChangeScene();
            }
        }

       if (target.gameObject.tag == "Car" && gameObject.tag == "Bullet")
       {
        Destroy(target.gameObject);  // ทำลายวัตถุที่มีแท็ก Car
        Destroy(gameObject);  // ทำลายกระสุนหลังจากชนแล้ว
       } 



    }

    private void ChangeScene()
    {
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
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{


    public int score;
    public static int hiScore = 10;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;

    public GameObject[] asteroidFields;
    public GameObject player;

    public Animator fadeScreen;
    public float transitionTime = 2F;


    public void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        hiScoreText.text = "Hi score: " + hiScore.ToString();

    }

       public void StarGame()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void Retry()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void Quit()
    {
        StartCoroutine(LoadLevel(0));
    }

    
    

    public IEnumerator LoadLevel(int levelToLoad)
    {
        fadeScreen.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2F);
        SceneManager.LoadScene(levelToLoad);
    }


    public void AddScore()
    {
        score += 10;
        scoreText.text = score.ToString();

        if(score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = "Hi score: " + hiScore.ToString();
            PlayerPrefs.SetInt("HiScore", hiScore);
            PlayerPrefs.Save();
        }

    }

    public void ClearData()
    {
        PlayerPrefs.SetInt("HiScore", 0);
        hiScore = PlayerPrefs.GetInt("HiScore"); 
        hiScoreText.text = "Hi score: " + hiScore.ToString();
        PlayerPrefs.Save();
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void SpawnAsteroidField()
    {
        int rnd = Random.Range(0,4);
        Instantiate(asteroidFields[rnd], new Vector3(player.transform.position.x, player.transform.position.y+100, player.transform.position.z), transform.rotation);
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject completeLevelUI;

    [SerializeField] PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        completeLevelUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void LevelCompleted()
    {
        playerMovement.enabled = false;
        gameOverPanel.SetActive(false);
        completeLevelUI.SetActive(true);
    }
   
   public void NextLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Levels()
    {
        SceneManager.LoadScene(1);
    }
}

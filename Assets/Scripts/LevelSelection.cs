using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(2);

    }

     public void LevelTwo()
    {
        SceneManager.LoadScene(3);

    }

     public void LevelThree()
    {
        SceneManager.LoadScene(4);

    }


}

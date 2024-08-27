using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    private float newPlayerPosition;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        newPlayerPosition = player.position.z + 1980f;
    }

    // Update is called once per frame
    void Update()
    {
        newPlayerPosition = player.position.z + 1980f;
        score.text = newPlayerPosition.ToString("0"); 
    }
}

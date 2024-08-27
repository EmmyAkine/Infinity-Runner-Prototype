using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject[] gameObject;
    private int count = 132;
    float zDistance = -1950;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(gameObject[Random.Range(0, gameObject.Length)], new Vector3(-8f, 1f, zDistance), Quaternion.identity);
            zDistance += 30f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

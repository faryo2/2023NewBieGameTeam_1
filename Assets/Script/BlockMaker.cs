using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float time;
    private int number;

    // Start is called before the first frame update
    void Start()
    {
        time = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            time = 5.0f;
            number = Random.Range(0, Prefabs.Length);
            Instantiate(Prefabs[number], new Vector3(0,10,-1), Quaternion.identity);
        }
    }
}

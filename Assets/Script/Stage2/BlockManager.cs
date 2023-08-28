using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ya1 yb1;
        GameObject ybobj1 = GameObject.Find("YaBoard1");
        yb1 = ybobj1.GetComponent<Ya1>();

        Ya2 yb2;
        GameObject ybobj2 = GameObject.Find("YaBoard2");
        yb2 = ybobj2.GetComponent<Ya2>();

        if (yb1.ya1 ==1 && yb2.ya2 ==1)
        {
            Debug.Log("ê≥âÅIÅI");
        }
    }
}

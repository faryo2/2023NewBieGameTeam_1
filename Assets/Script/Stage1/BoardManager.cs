using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ha hb;
        GameObject hbobj = GameObject.Find("HaBoard");
        hb = hbobj.GetComponent<Ha>();

        if (hb.ha ==1)
        {
            Debug.Log("ê≥âÅIÅI");
        }
    }
}

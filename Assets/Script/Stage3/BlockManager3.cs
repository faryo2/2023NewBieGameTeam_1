using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class BlockManager3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Chi cb;
        GameObject cbobj = GameObject.Find("ChiBoard");
        cb = cbobj.GetComponent<Chi>();

        Ha hb;
        GameObject hbobj = GameObject.Find("HaBoard");
        hb = hbobj.GetComponent<Ha>();

        Ya yb;
        GameObject ybobj = GameObject.Find("YaBoard");
        yb = ybobj.GetComponent<Ya>();

        if (cb.chi == 1 && hb.ha ==1 && yb.ya ==1)
        {
            Debug.Log("ê≥âÅIÅI");
            SceneManager.LoadScene("Omigoto");
        }
    }
}

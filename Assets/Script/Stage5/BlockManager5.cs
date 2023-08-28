using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Chi1 cb1;
        GameObject cbobj1 = GameObject.Find("ChiBoard1");
        cb1 = cbobj1.GetComponent<Chi1>();

        Chi2 cb2;
        GameObject cbobj2 = GameObject.Find("ChiBoard2");
        cb2 = cbobj2.GetComponent<Chi2>();

        Ha hb;
        GameObject hbobj = GameObject.Find("HaBoard");
        hb = hbobj.GetComponent<Ha>();

        Ya1 yb1;
        GameObject ybobj1 = GameObject.Find("YaBoard1");
        yb1 = ybobj1.GetComponent<Ya1>();

        Ya2 yb2;
        GameObject ybobj2 = GameObject.Find("YaBoard2");
        yb2 = ybobj2.GetComponent<Ya2>();

        if (cb1.chi1 == 1 && cb2.chi2 == 1 && hb.ha ==1 && yb1.ya1 ==1 && yb2.ya2 ==1)
        {
            Debug.Log("ê≥âÅIÅI");
        }
    }
}

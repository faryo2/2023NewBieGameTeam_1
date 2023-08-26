using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    [SerializeField] private float blockSpeed;
    [SerializeField] private float blockLifeTime;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(0, -blockSpeed, 0) * Time.deltaTime);

        //BlockLifeTime秒後にオブジェクトを消す
        blockLifeTime = blockLifeTime - Time.deltaTime;
        if (blockLifeTime < 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

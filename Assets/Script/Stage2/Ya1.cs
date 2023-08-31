using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class Ya1 : MonoBehaviour
{
    public int ya1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //座標を取得
        Transform myTransform = this.transform;

        //座標の変更
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 pos = myTransform.position;
            pos.x -= 2f;
            myTransform.position = pos;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 pos = myTransform.position;
            pos.x += 2f;
            myTransform.position = pos;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ya"))
        {
            // 触れたobjの親を移動床にする
            other.transform.SetParent(transform);
            ya1 = 1;
            Debug.Log("「や」が正しく配置されたよ！！");
        }
        if (other.gameObject.CompareTag("Ha"))
        {
            // 触れたobjの親を移動床にする
            other.transform.SetParent(transform);
            Debug.Log("不正解！！");
            ya1 = -1;
        }
        if (other.gameObject.CompareTag("Chi"))
        {
            // 触れたobjの親を移動床にする
            other.transform.SetParent(transform);
            Debug.Log("不正解！！");
            ya1 = -1;
        }
    }
}

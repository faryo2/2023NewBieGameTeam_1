using System.Collections;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    public bool DontDestroyEnabled = true;

    //use this for initialization
    void Start()
    {
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
    }
    private void Awake()
    {
        int numMainSounds = FindObjectsOfType<MainSound>().Length;
        if (numMainSounds>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

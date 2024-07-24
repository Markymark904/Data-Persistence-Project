using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    public static PlayerDataHandle Instance;

    public string PlayerName;

    public int Score;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

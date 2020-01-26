using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagManager : MonoBehaviour
{
    Flag[] flagsInLevel;
    float flagsToWin;
    public string nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        flagsInLevel = FindObjectsOfType<Flag>();
        flagsToWin = flagsInLevel.Length;
    }

    // Update is called once per frame
    void Update()
    {
        // check flags are captured
        if (CheckFlags())
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    bool CheckFlags()
    {
        bool result = true;
        foreach (Flag f in flagsInLevel)
        {
            if (f.captured == false)
            {
                result = false;
            }
        }
        return result;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Flag : MonoBehaviour
{
    public bool captured;
    public float timeToCapture;
    public float timeSoFar;

    public Image UI;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSoFar > timeToCapture)
        {
            captured = true;
            UI.gameObject.SetActive (true);
        }
    }
    void OnTriggerStay(Collider collider)
    {
            if (collider.gameObject.tag == "Player") {
                timeSoFar += Time.deltaTime;
            }
    }
    void OnTriggerExit(Collider collider)
    {
            if (collider.gameObject.tag == "Player")
            {
                if (captured == false)
                {
                    timeSoFar = 0;
                }
            }
      
    }
}

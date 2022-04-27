using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMenu : MonoBehaviour
{
    public questGiver giver;
    public GameObject HelmetCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            HelmetCamera.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            HelmetCamera.SetActive(false);
        }
    }

} 

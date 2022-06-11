using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornholePlayer : MonoBehaviour
{

    public GameObject playerUIMenu;

    // Start is called before the first frame update
    void Start()
    {
        playerUIMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMenu();
    }

    public void PlayerMenu()
    {
        // if (OVRInput.GetDown(OVRInput.Button.Three) || Input.GetKeyDown(KeyCode.Space))
        // {
        //     playerUIMenu.SetActive(true);
        // }
    }
}

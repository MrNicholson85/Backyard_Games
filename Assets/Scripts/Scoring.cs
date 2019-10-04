using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    [SerializeField]
    private UIManager _uiManager;

    public bool isRed;
    public bool isBlue;

    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isRed == true) {
            if (other.gameObject.tag == "RedTeamBag")
            {
                Debug.Log("Point Red");
                _uiManager.UpdateRedScore3();
            }
        }

        if (isBlue == true)
        {
            if (other.gameObject.tag == "BlueTeamBag")
            {
                Debug.Log("Point Blue");
                _uiManager.UpdateBlueScore3();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardScoring : MonoBehaviour
{
    [SerializeField]
    private UIManager _uiManager;

    public bool isRed;
    public bool isBlue;
	private float stayCount = 0.0f;

	// Start is called before the first frame update
	void Start()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    private void OnTriggerStay(Collider other)
    {
		if (stayCount >= 2.0f)
		{
			Debug.Log("staying");

			if (isRed == true)
			{
				if (other.gameObject.tag == "RedTeamBag")
				{
					Debug.Log("Point Red");
					_uiManager.UpdateRedScore1();
				}
			}

			if (isBlue == true)
			{
				if (other.gameObject.tag == "BlueTeamBag")
				{
					Debug.Log("Point Blue");
					_uiManager.UpdateBlueScore1();
				}
			}
		}
		else
		{
			stayCount = stayCount + Time.deltaTime;
		}

		
    }
}

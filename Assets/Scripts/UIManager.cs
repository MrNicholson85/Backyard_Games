using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    public TextMeshProUGUI redScoreText;
    public TextMeshProUGUI blueScoreText;

    public GameObject RedTeamWins;
    public GameObject BlueTeamWins;

    public int FinalScore;

    public int redScore;
    public int blueScore;


    private void Start()
    {
        redScore = 0;
        blueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        WinningTeam();
    }

    public void UpdateRedScore3()
    {
        redScore += 3;
        redScoreText.text = redScore.ToString();
    }

    public void UpdateRedScore1()
    {
        redScore += 1;
        redScoreText.text = redScore.ToString();
    }

    public void UpdateBlueScore3()
    {
        blueScore += 3;
        blueScoreText.text = blueScore.ToString();
    }

    public void UpdateBlueScore1()
    {
        blueScore += 1;
        blueScoreText.text = blueScore.ToString();
    }

    public void WinningTeam()
    {
        if (redScore == FinalScore)
        {
            Debug.Log("Red Team Wins with a score of " + redScore.ToString());
            RedTeamWins.SetActive(true);
        }

        if (blueScore == FinalScore)
        {
            Debug.Log("Blue Team Wins with a score " + blueScore.ToString());
            BlueTeamWins.SetActive(true);


        }
    }
}

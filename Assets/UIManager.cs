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

    public int redScore;
    public int blueScore;


    private void Start()
    {
        //redScoreText = GetComponent<TextMeshProUGUI>();

        redScore = 0;
        blueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateRedScore()
    {
        redScore += 3;
        redScoreText.text = redScore.ToString();
    }

    public void UpdateBlueScore()
    {
        blueScore += 3;
        blueScoreText.text = blueScore.ToString();
    }
}

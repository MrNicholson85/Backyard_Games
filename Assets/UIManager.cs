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


    private void Awake()
    {
        //redScoreText = GetComponent<TextMeshProUGUI>();

        redScore = 0;
        blueScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
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
        redScore += 3;
        redScoreText.text = redScore.ToString();
    }
}

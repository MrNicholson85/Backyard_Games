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
        m_TextComponent = GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateRedScore()
    {
        redScore += 1;
        m_TextComponent.text = "Test" + redScore;
    }
}

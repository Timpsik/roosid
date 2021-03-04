using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreHandler : MonoBehaviour
{
    public Text totalScore;

    public Text answerScore_1;
    public Text answerScore_2;
    public Text answerScore_3;
    public Text answerScore_4;
    public Text answerScore_5;

    // Start is called before the first frame update
    void Awake()
    {
        totalScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        int newTotalScore = 0;
        if (answerScore_1.text.Equals(""))
        {
            totalScore.text = "0";
            return;
        }
        newTotalScore += int.Parse(answerScore_1.text, System.Globalization.NumberStyles.Integer);
        if (answerScore_2.text.Equals(""))
        {
            totalScore.text = newTotalScore.ToString();
            return;
        }
        newTotalScore += int.Parse(answerScore_2.text, System.Globalization.NumberStyles.Integer);
        if (answerScore_3.text.Equals(""))
        {
            totalScore.text = newTotalScore.ToString();
            return;
        }
        newTotalScore += int.Parse(answerScore_3.text, System.Globalization.NumberStyles.Integer);
        if (answerScore_4.text.Equals(""))
        {
            totalScore.text = newTotalScore.ToString();
            return;
        }
        newTotalScore += int.Parse(answerScore_4.text, System.Globalization.NumberStyles.Integer);
        if (answerScore_5.text.Equals(""))
        {
            totalScore.text = newTotalScore.ToString();
            return;
        }
        newTotalScore += int.Parse(answerScore_5.text, System.Globalization.NumberStyles.Integer);
        totalScore.text = newTotalScore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameAnswerController : MonoBehaviour
{
    public GameObject inputField;
    public Text answer;
    public Text score;

    private Dictionary<string, string> answerDict = new Dictionary<string, string>();

    void Awake()
    {
        Debug.Log("Input not active");
        inputField.SetActive(false);
        inputField.GetComponent<InputField>().onEndEdit.AddListener(SetAnswer);
        score.text = "";
        answer.text = "";
    }

    public void SetAnswer(string newAnswer)
    {
        answer.text = newAnswer;
        inputField.SetActive(false);
        if (answerDict.ContainsKey(newAnswer.ToLower()))
        {
            SetScore(answerDict[newAnswer.ToLower()]);
        } else
        {
            SetScore("0");
        }
    }


    public void SetScore(string newScore)
    {
        score.text = newScore;
    }

    public void SetDict(ArrayList qa)
    {
        Debug.Log("Adding answers");
        for (int i = 0; i < qa.Count; i++)
        {
            Debug.Log("Adding: " + ((QuestionAnswer) qa[i]).GetAnswer().ToLower());
            answerDict.Add(((QuestionAnswer)qa[i]).GetAnswer().ToLower(), ((QuestionAnswer)qa[i]).GetPoints());
        }


    }
}

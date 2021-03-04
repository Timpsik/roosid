using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionAnswer
{
    private string answer;
    private string points;
   
    public QuestionAnswer(string answer, string points) {
        this.answer = answer;
        this.points = points;
    }
    public string GetAnswer()
    {
        return answer;
    }

    public void SetAnswer(string answer)
    {
        this.answer = answer;
    }

    public string GetPoints()
    {
        return points;
    }

    public void SetPoints(string points)
    {
        this.points = points;
    }
}

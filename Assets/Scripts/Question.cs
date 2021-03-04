using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    private string question;
    private LinkedList<QuestionAnswer> answers;
    
    public Question(string question, LinkedList<QuestionAnswer> answers)
    {
        this.question = question;
        this.answers = answers;
    }

    public void SetQuestion(string question)
    {
        this.question = question;
    }

    public string GetQuestion()
    {
        return question;
    }

    public LinkedList<QuestionAnswer> GetAnswers()
    {
        return answers;
    }

}

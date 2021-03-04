using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyFeudGame 
{
    private LinkedList<Question> mainGameQuestions;
    private LinkedList<Question> endGameQuestions;


    public FamilyFeudGame(LinkedList<Question> mainGameQuestions, LinkedList<Question> endGameQuestions)
    {
        this.mainGameQuestions = mainGameQuestions;
        this.endGameQuestions = endGameQuestions;
    }

    public LinkedList<Question> GetMainGameQuestions()
    {
        return mainGameQuestions;
    }

    public LinkedList<Question> GetEndGameQuestions()
    {
        return endGameQuestions;
    }
}

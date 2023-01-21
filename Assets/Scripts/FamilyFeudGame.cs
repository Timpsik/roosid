using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyFeudGame 
{
    private JSONQuestion[] mainGameQuestions;
    private JSONQuestion[] endGameQuestions;


    public FamilyFeudGame(JSONQuestion[] mainGameQuestions, JSONQuestion[] endGameQuestions)
    {
        this.mainGameQuestions = mainGameQuestions;
        this.endGameQuestions = endGameQuestions;
    }

    public JSONQuestion[] GetMainGameQuestions()
    {
        return mainGameQuestions;
    }

    public JSONQuestion[] GetEndGameQuestions()
    {
        return endGameQuestions;
    }
}

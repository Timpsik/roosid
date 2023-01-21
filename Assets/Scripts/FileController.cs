using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class FileController : MonoBehaviour
{
    public FamilyFeudGame ReadQuestions()
    {
        GameData gameData = readJsonFileAsJSON();

        return new FamilyFeudGame(gameData.mainGame.questions, gameData.fastMoney.questions);
    }
    
    private GameData readJsonFileAsJSON() 
    {
        string url = Path.Combine(Application.streamingAssetsPath, "newFormatQuestions.json");
        FileStream fs = File.Open(url, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs, Encoding.UTF8);

        GameData gameData = JsonUtility.FromJson<GameData>(reader.ReadToEnd());
 
        foreach (JSONQuestion question in gameData.mainGame.questions)
        {
            Debug.Log("Found main game question: " + question.question);
        }   
        
        return gameData;
    }
}

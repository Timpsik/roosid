using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class FileController : MonoBehaviour
{
    public FamilyFeudGame ReadQuestions()
    {
        string url = Path.Combine(Application.streamingAssetsPath, "questions.txt");
        FileStream fs = File.Open(url, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs, Encoding.UTF8);

        string line = string.Empty;
        LinkedList<Question> mainGameQuestions = new LinkedList<Question>();
        string[] lineParts;
        int counter = 0;
        while (!(line = reader.ReadLine()).Equals("EndGame"))
        {
            Debug.Log(line);
            counter = 0;
            lineParts = line.Split('\t');
            string questionName = lineParts[0];
            int answerCount = int.Parse(lineParts[1]);
            LinkedList<QuestionAnswer> answers = new LinkedList<QuestionAnswer>();
            while (counter < answerCount)
            {
                line = reader.ReadLine();
                Debug.Log(line);
                lineParts = line.Split('\t');
                answers.AddLast(new QuestionAnswer(lineParts[0], lineParts[1]));
                counter++;
            }
            mainGameQuestions.AddLast(new Question(questionName, answers));
        }
        LinkedList<Question> endGameQuestions = new LinkedList<Question>();
        while ((line = reader.ReadLine()) != null)
        {
            Debug.Log(line);
            counter = 0;
            lineParts = line.Split('\t');
            string questionName = lineParts[0];
            int answerCount = int.Parse(lineParts[1]);
            LinkedList<QuestionAnswer> answers = new LinkedList<QuestionAnswer>();
            while (counter < answerCount)
            {
                line = reader.ReadLine();
                Debug.Log(line);
                lineParts = line.Split('\t');
                answers.AddLast(new QuestionAnswer(lineParts[0], lineParts[1]));
                counter++;
            }
            endGameQuestions.AddLast(new Question(questionName, answers));
        }
        return new FamilyFeudGame(mainGameQuestions, endGameQuestions);
    }
}

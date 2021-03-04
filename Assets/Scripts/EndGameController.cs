using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{

    public FileController fc;
    public GameObject Player_1;
    public GameObject Player_2;
    // Start is called before the first frame update

    private LinkedList<Question> endGameQuestions;

    void Awake()
    {
        endGameQuestions = fc.ReadQuestions().GetEndGameQuestions();
        Transform answers_1 = Player_1.transform.Find("Answers");
        Transform answers_2 = Player_2.transform.Find("Answers");
        LinkedList<QuestionAnswer> qa = endGameQuestions.First.Value.GetAnswers();
        ArrayList ans1 = new ArrayList();
        while(qa.Count > 0)
        {
            ans1.Add(qa.First.Value);
            qa.RemoveFirst();
        }
        answers_2.Find("Answer_1").GetComponent<EndGameAnswerController>().SetDict(ans1);
        answers_1.Find("Answer_1").GetComponent<EndGameAnswerController>().SetDict(ans1);
        endGameQuestions.RemoveFirst();
        qa = endGameQuestions.First.Value.GetAnswers();
        ArrayList ans2 = new ArrayList();
        while (qa.Count > 0)
        {
            ans2.Add(qa.First.Value);
            qa.RemoveFirst();
        }
        answers_2.Find("Answer_2").GetComponent<EndGameAnswerController>().SetDict(ans2);
        answers_1.Find("Answer_2").GetComponent<EndGameAnswerController>().SetDict(ans2);
        endGameQuestions.RemoveFirst();
        qa = endGameQuestions.First.Value.GetAnswers();
        ArrayList ans3 = new ArrayList();
        while (qa.Count > 0)
        {
            ans3.Add(qa.First.Value);
            qa.RemoveFirst();
        }
        answers_2.Find("Answer_3").GetComponent<EndGameAnswerController>().SetDict(ans3);
        answers_1.Find("Answer_3").GetComponent<EndGameAnswerController>().SetDict(ans3);
        endGameQuestions.RemoveFirst();
        qa = endGameQuestions.First.Value.GetAnswers();
        ArrayList ans4 = new ArrayList();
        while (qa.Count > 0)
        {
            ans4.Add(qa.First.Value);
            qa.RemoveFirst();
        }
        answers_2.Find("Answer_4").GetComponent<EndGameAnswerController>().SetDict(ans4);
        answers_1.Find("Answer_4").GetComponent<EndGameAnswerController>().SetDict(ans4);
        endGameQuestions.RemoveFirst();
        qa = endGameQuestions.First.Value.GetAnswers();
        ArrayList ans5 = new ArrayList();
        while (qa.Count > 0)
        {
            ans5.Add(qa.First.Value);
            qa.RemoveFirst();
        }
        answers_2.Find("Answer_5").GetComponent<EndGameAnswerController>().SetDict(ans5);
        answers_1.Find("Answer_5").GetComponent<EndGameAnswerController>().SetDict(ans5);
        endGameQuestions.RemoveFirst();
    }


}

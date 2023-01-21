using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{

    public FileController fc;
    public GameObject Player_1;
    public GameObject Player_2;
    // Start is called before the first frame update

    private JSONQuestion[] endGameQuestions;

    void Awake()
    {
        endGameQuestions = fc.ReadQuestions().GetEndGameQuestions();
        Transform answers_1 = Player_1.transform.Find("Answers");
        Transform answers_2 = Player_2.transform.Find("Answers");

        for (int i = 0; i < endGameQuestions.Length; i++) {
            ArrayList answers = new ArrayList();
        
            foreach (JSONAnswer answer in endGameQuestions[i].answers) {
                answers.Add(answer);
            }

            answers_2.Find("Answer_" + (i + 1)).GetComponent<EndGameAnswerController>().SetDict(answers);
            answers_1.Find("Answer_" + (i + 1)).GetComponent<EndGameAnswerController>().SetDict(answers);
        }
    }


}

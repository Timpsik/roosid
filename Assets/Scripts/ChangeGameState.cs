using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeGameState : MonoBehaviour
{
    private string QUESTION_ROUND = "gameBoard";
    private string SCORE_ROUND = "empty_feud";

    [SerializeField]
    private GameObject Team_1_UI;

    [SerializeField]
    private GameObject Team_2_UI;

    [SerializeField]
    private GameObject panel;

    [SerializeField]
    private GameObject scoreButton;

    [SerializeField]
    private GameObject questionButton;

    [SerializeField]
    private GameObject questionUI;

    [SerializeField]
    private AudioSource theme;

    private bool showingScore = true;

    private int nextQuestionIndex = 0;

    private JSONQuestion[] questions;

    private FileController fileController;

    private FamilyFeudGame game;

    private Dictionary<string, Sprite> panelPictures = new Dictionary<string, Sprite>();

    void Awake()
    {
        Sprite[] backgrounds = Resources.LoadAll<Sprite>("Backgrounds");
        foreach (Sprite background in backgrounds) {
            Debug.Log("Adding background: " + background.name);
            panelPictures.Add(background.name, background);
            questionButton.SetActive(false);
            questionUI.SetActive(false);
        }
        fileController = GetComponent<FileController>();
        game = fileController.ReadQuestions();
        questions = game.GetMainGameQuestions();
        theme.Play();
    }

    public void ChangePanelImage()
    {
        if (showingScore)
        {
            if (questions.Length <= nextQuestionIndex)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("FastMoney");
            } else
            {
                panel.GetComponent<Image>().sprite = panelPictures[QUESTION_ROUND];
                showingScore = false;
                Team_1_UI.SetActive(false);
                Team_2_UI.SetActive(false);
                questionButton.SetActive(true);
                scoreButton.SetActive(false);
                questionUI.SetActive(true);
                questionUI.GetComponent<QuestionPreparer>().CreateGameBoard(questions[nextQuestionIndex]);
                theme.Stop();
                nextQuestionIndex++;
            }
        } else
        {
            panel.GetComponent<Image>().sprite = panelPictures[SCORE_ROUND];
            showingScore = true;
            Team_1_UI.SetActive(true);
            Team_2_UI.SetActive(true);
            Team_1_UI.transform.Find("ChangeName").GetComponentInChildren<Text>().text = "Add points";
            Team_2_UI.transform.Find("ChangeName").GetComponentInChildren<Text>().text = "Add points";
            Team_1_UI.transform.Find("TeamNameButtonClick").GetComponent<ChangeTeamName>().StartGame();
            Team_2_UI.transform.Find("TeamNameButtonClick").GetComponent<ChangeTeamName>().StartGame();
            questionButton.SetActive(false);
            questionUI.SetActive(false);
            scoreButton.SetActive(true);
        }
    }

}

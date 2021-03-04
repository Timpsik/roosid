using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionPreparer : MonoBehaviour
{
    [SerializeField]
    private GameObject[] answerSlots;

    [SerializeField]
    private GameObject questionOverlay;

    [SerializeField]
    private TextMeshProUGUI questionPoints;

    public void CreateGameBoard(Question question)
    {
        questionPoints.SetText("0");
        string questionString = question.GetQuestion();
        questionOverlay.GetComponentInChildren<TextMeshProUGUI>().SetText(questionString);
        questionOverlay.SetActive(false);
        int answerSlotIndex = 0;
        foreach (QuestionAnswer answer in question.GetAnswers())
        {
            GameObject answerSlot = answerSlots[answerSlotIndex].transform.Find("Answer").gameObject;
            answerSlot.transform.Find("AnswerText").GetComponent<TextMeshProUGUI>().SetText(answer.GetAnswer());
            answerSlot.transform.Find("AnswerPoints").GetComponent<TextMeshProUGUI>().SetText(answer.GetPoints());
            answerSlots[answerSlotIndex].SetActive(true);
            answerSlot.SetActive(false);
            string image = "Answers/" + (answerSlotIndex + 1).ToString();
            Debug.Log(image);
            Sprite newImage = Resources.Load<Sprite>(image);
            answerSlots[answerSlotIndex].GetComponent<Image>().sprite = newImage;
            answerSlots[answerSlotIndex].GetComponent<Button>().interactable = true;

            answerSlots[answerSlotIndex].transform.Find("AnswerController").gameObject.GetComponent<ShowAnswer>().SetAddingPoints(true);
            answerSlotIndex++;
        }
        while (answerSlotIndex < answerSlots.Length)
        {
            answerSlots[answerSlotIndex].SetActive(false);
            answerSlotIndex++;
        }
        GetComponentInChildren<MistakeController>().ResetAllMistakes();
    }
}

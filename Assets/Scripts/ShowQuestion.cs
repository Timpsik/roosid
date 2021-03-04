using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuestion : MonoBehaviour
{
    [SerializeField]
    private GameObject questionOverlay;

    [SerializeField]
    private GameObject answers;

    [SerializeField]
    private GameObject earnedPoints;

    [SerializeField]
    private GameObject mistakes;
    public void ShowQuestionOverlay()
    {
        questionOverlay.SetActive(true);
        answers.SetActive(false);
        earnedPoints.SetActive(false);
        mistakes.SetActive(false);
    }

    public void HideQuestion()
    {
        answers.SetActive(true);
        questionOverlay.SetActive(false);
        earnedPoints.SetActive(true);
        mistakes.SetActive(true);
    }
}

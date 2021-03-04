using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowAnswer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoredPoints;
    
    [SerializeField]
    private GameObject answer;

    [SerializeField]
    private Button answerSlot;

    [SerializeField]
    private AudioSource soundEffect;


    private bool addingPoints = true;


    void Awake()
    {
        answer.SetActive(false);
    }

    public void RevealAnswer()
    {
        answer.SetActive(true);
        if (addingPoints)
        {
            string givenPoints = answer.transform.Find("AnswerPoints").GetComponent<TextMeshProUGUI>().text;
            scoredPoints.SetText((int.Parse(scoredPoints.text) + (int.Parse(givenPoints))).ToString());
        }
        soundEffect.Play();
        Sprite guessed = Resources.Load<Sprite>("Answers/Guessed");
        answerSlot.image.sprite = guessed;
        answerSlot.interactable = false;
    }

    public void SetAddingPoints(bool newValue)
    {
        addingPoints = newValue;
    }
}

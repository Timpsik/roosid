using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MistakeController : MonoBehaviour
{
    [SerializeField]
    private Button[] mistakeButtons;

    [SerializeField]
    private AudioSource soundEffect;

    public void MistakeMade(Button button)
    {
        button.image.sprite = Resources.Load<Sprite>("Answers/mistake");
        button.interactable = false;
        soundEffect.Play();
    }

    public void ResetAllMistakes()
    {
        foreach (Button button in mistakeButtons)
        {
            button.image.sprite = Resources.Load<Sprite>("Answers/unclicked");
            button.interactable = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTeamName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI teamName;

    [SerializeField]
    private TextMeshProUGUI teamScore;

    [SerializeField]
    private GameObject newTeamNamePrefab;
    // Start is called before the first frame update

    [SerializeField]
    private Text buttonText;

    [SerializeField]
    private Canvas parentCanvas;

    [SerializeField]
    private TextMeshProUGUI scoredPoints;


    private GameObject newTeamName;

    private bool editing = false;

    private bool startUp = true;
    

    public void ChangeTeamNameButtonClicked()
    {
        if (startUp)
        {
            if (!editing)
            {
                buttonText.text = "Save name";
                newTeamName = Instantiate(newTeamNamePrefab, Vector3.zero, Quaternion.identity);
                newTeamName.transform.SetParent(parentCanvas.transform, false);
                newTeamName.transform.position = teamName.transform.position;
                newTeamName.transform.rotation = teamName.transform.rotation;
                newTeamName.SetActive(true);
                teamName.SetText("");
                editing = true;
                ((InputField)newTeamName.GetComponent<InputField>()).Select();
                ((InputField)newTeamName.GetComponent<InputField>()).ActivateInputField();
            }
            else
            {
                string newName = ((InputField)newTeamName.GetComponent<InputField>()).text;
                ((InputField)newTeamName.GetComponent<InputField>()).DeactivateInputField();
                teamName.SetText(newName);
                newTeamName.SetActive(false);
                newTeamNamePrefab.SetActive(false);
                Destroy(newTeamName);
                buttonText.text = "Change name";
                editing = false;
            }
        } else
        {
            // Add points
            int points = int.Parse(scoredPoints.text);
            int currentPoints = int.Parse(teamScore.text);
            teamScore.text = (currentPoints + points).ToString();
        }


    }

    public void StartGame()
    {
        startUp = false;
    }
}

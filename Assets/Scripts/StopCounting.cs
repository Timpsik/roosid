using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCounting : MonoBehaviour
{
    [SerializeField]
    private GameObject[] answerSlots;


    public void StopCountingPoints()
    {
        foreach (GameObject slot in answerSlots)
        {
            slot.GetComponentInChildren<ShowAnswer>().SetAddingPoints(false);
        }
    }
}



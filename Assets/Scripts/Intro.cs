using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    [Header("Dialog Components")]
    public GameObject[] dialogBoxes;

    [Header("Dialog Variables")]
    public float dialogLength = 5f;
    private float currentDialogLength, nextDialogBox;
    private int currentDialogID = 0;
    private void Start()
    {

    }

    private void Update()
    {
        if (Time.time > nextDialogBox)
            NextDialog(currentDialogID);
        if (Input.anyKeyDown)
            NextDialog(currentDialogID);
    }

    void NextDialog(int dialogID)
    {
        if (currentDialogID > dialogBoxes.Length)
            return;

        currentDialogID++;

        for (int i = 0; i < dialogBoxes.Length; i++)
        {
            dialogBoxes[i].SetActive(false);
        }
        dialogBoxes[dialogID].SetActive(true);
        nextDialogBox = Time.time + dialogLength;
    }

}

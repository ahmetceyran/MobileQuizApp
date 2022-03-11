using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001;
    
    void Update()
    {
        if(displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 7);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "How much wood could a wood chuck chuck if a wood chuck could chuck wood?";
                QuestionDisplay.newA = "A. Lots and lots";
                QuestionDisplay.newB = "B. None";
                QuestionDisplay.newC = "C. Hardly any";
                QuestionDisplay.newD = "D. Six";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who is the brother of Luigi?";
                QuestionDisplay.newA = "A. D.K";
                QuestionDisplay.newB = "B. Toad";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                actualAnswer = "C";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Where is Japan?";
                QuestionDisplay.newA = "A. Africa";
                QuestionDisplay.newB = "B. Asia";
                QuestionDisplay.newC = "C. Europe";
                QuestionDisplay.newD = "D. Antartica";
                actualAnswer = "B";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who is the first president of Turkey?";
                QuestionDisplay.newA = "A. George Washington";
                QuestionDisplay.newB = "B. Ghandi";
                QuestionDisplay.newC = "C. Erdogan";
                QuestionDisplay.newD = "D. Ataturk";
                actualAnswer = "D";
            }

            if(questionNumber == 5)
            { 
                QuestionDisplay.newQuestion = "How old the is world?";
                QuestionDisplay.newA = "A. 1400 years";
                QuestionDisplay.newB = "B. 6 months";
                QuestionDisplay.newC = "C. 10 years";
                QuestionDisplay.newD = "D. Billons of years";
                actualAnswer = "D";
            }

            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Which video game series would you see this?";
                QuestionDisplay.newA = "A. Zelda";
                QuestionDisplay.newB = "B. Halo";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                visual001.SetActive(true);
                actualAnswer = "C";
            }

            QuestionDisplay.pleaseUpdate = false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    [SerializeField] private GameObject answerAbackBlue;
    [SerializeField] private GameObject answerAbackGreen;
    [SerializeField] private GameObject answerAbackRed;

    [SerializeField] private GameObject answerBbackBlue;
    [SerializeField] private GameObject answerBbackGreen;
    [SerializeField] private GameObject answerBbackRed;

    [SerializeField] private GameObject answerCbackBlue;
    [SerializeField] private GameObject answerCbackGreen;
    [SerializeField] private GameObject answerCbackRed;

    [SerializeField] private GameObject answerDbackBlue;
    [SerializeField] private GameObject answerDbackGreen;
    [SerializeField] private GameObject answerDbackRed;

    [SerializeField] private GameObject answerA;
    [SerializeField] private GameObject answerB;
    [SerializeField] private GameObject answerC;
    [SerializeField] private GameObject answerD;

    [SerializeField] private AudioSource correctFX;
    [SerializeField] private AudioSource incorrectFX;

    [SerializeField] private GameObject currentScore;
    private int scoreValue;
    private int bestScore;
    private int coinAmount;
    [SerializeField] private GameObject bestDisplay;
    [SerializeField] private GameObject coinDisplay;
    [SerializeField] private GameObject visual001;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        coinAmount = PlayerPrefs.GetInt("CoinAmount");
        coinDisplay.GetComponent<Text>().text = "Coin : " + coinAmount;
        bestDisplay.GetComponent<Text>().text = "Best : " + bestScore;
    }

    void Update()
    {

        currentScore.GetComponent<Text>().text = "SCORE : " + scoreValue;
        coinDisplay.GetComponent<Text>().text = "Coin : " + coinAmount;
    }

    public void AnswerA()
    {
        if(QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            coinAmount += 1;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            coinAmount += 1;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            coinAmount += 1;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            coinAmount += 1;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if(bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "Best : " + scoreValue;
        }
        yield return new WaitForSeconds(1.5f);

        PlayerPrefs.SetInt("CoinAmount", coinAmount);
        visual001.SetActive(false);
        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);
        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerate.displayingQuestion = false;
    }
}

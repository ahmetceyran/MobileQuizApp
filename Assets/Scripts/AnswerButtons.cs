using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    [SerializeField] private Button btnJoker;
    [SerializeField] private Button btnJokerScreenClose;
    [SerializeField] private Button btnDoubleJoker;
    [SerializeField] private Button btnFiftyJoker;
    [SerializeField] private Button btnPassJoker;
    [SerializeField] private GameObject UseJokerScreen;
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

    [SerializeField] private Text doubleDisplay;
    [SerializeField] private Text fiftyDisplay;
    [SerializeField] private Text passDisplay;

    private int doubleAmount;
    private int fiftyAmount;
    private int passAmount;
    private int scoreValue;
    private int bestScore;
    private int coinAmount;
    private bool doubleAnswer;
    [SerializeField] private GameObject bestDisplay;
    [SerializeField] private GameObject coinDisplay;
    [SerializeField] private GameObject visual001;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        doubleAnswer = false;
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        coinAmount = PlayerPrefs.GetInt("CoinAmount");
        coinDisplay.GetComponent<Text>().text = "Coin : " + coinAmount;
        bestDisplay.GetComponent<Text>().text = "Best : " + bestScore;
        UseJokerScreen.SetActive(false);
        btnJoker.onClick.AddListener(TaskOnClick);
        btnJokerScreenClose.onClick.AddListener(TaskOnClick1);
        btnDoubleJoker.onClick.AddListener(TaskOnClick2);
        btnFiftyJoker.onClick.AddListener(TaskOnClick3);
        btnPassJoker.onClick.AddListener(TaskOnClick4);
    }

    void Update()
    {
        fiftyAmount = PlayerPrefs.GetInt("FiftyAmount");
        passAmount = PlayerPrefs.GetInt("PassAmount");
        doubleAmount = PlayerPrefs.GetInt("DoubleAmount");
        doubleDisplay.text = "Kalan : " + doubleAmount;
        fiftyDisplay.text = "Kalan : " + fiftyAmount;
        passDisplay.text = "Kalan : " + passAmount;

        currentScore.GetComponent<Text>().text = "SCORE : " + scoreValue;
        coinDisplay.GetComponent<Text>().text = "Coin : " + coinAmount;
    }

    public void AnswerA()
    {
        if(!doubleAnswer)
        {
            if(QuestionGenerate.actualAnswer == "A")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
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
        if(doubleAnswer)
        {
            if(QuestionGenerate.actualAnswer == "A")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
            }
            else
            {
                answerAbackRed.SetActive(true);
                answerAbackBlue.SetActive(false);
                incorrectFX.Play();
                doubleAnswer = false;
            }
        }
        
    }

    public void AnswerB()
    {
        if(!doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "B")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
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
        if(doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "B")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
            }
            else
            {
                answerBbackRed.SetActive(true);
                answerBbackBlue.SetActive(false);
                incorrectFX.Play();
                doubleAnswer = false;
            }
        }
        
    }

    public void AnswerC()
    {
        if(!doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "C")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
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
        
        if(doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "C")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
            }
            else
            {
                answerCbackRed.SetActive(true);
                answerCbackBlue.SetActive(false);
                incorrectFX.Play();
                doubleAnswer = false;
            }
        }
        
    }

    public void AnswerD()
    {
        if(!doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "D")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
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
        if(doubleAnswer)
        {
            if (QuestionGenerate.actualAnswer == "D")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
                correctFX.Play();
                scoreValue += 5;
                coinAmount += 1;
                PlayerPrefs.SetInt("CoinAmount", coinAmount);
            }
            else
            {
                answerDbackRed.SetActive(true);
                answerDbackBlue.SetActive(false);
                incorrectFX.Play();
                doubleAnswer = false;
            }
        }
        
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
        UseJokerScreen.SetActive(false);
        QuestionGenerate.displayingQuestion = false;
    }

    void TaskOnClick()
    {
        UseJokerScreen.SetActive(true);
    }
    void TaskOnClick1()
    {
        UseJokerScreen.SetActive(false);
    }
    void TaskOnClick2()
    {
        if(doubleAmount > 0)
        {
            doubleAmount--;
            PlayerPrefs.SetInt("DoubleAmount", doubleAmount);
            doubleAnswer = true;
        }
    }
    void TaskOnClick3()
    {
        if(fiftyAmount > 0)
        {
            fiftyAmount--;
            PlayerPrefs.SetInt("FiftyAmount", fiftyAmount);
        }
    }
    void TaskOnClick4()
    {
        if(passAmount > 0)
        {
            passAmount--;
            PlayerPrefs.SetInt("PassAmount", passAmount);
            StartCoroutine(NextQuestion());
        }
    }
}

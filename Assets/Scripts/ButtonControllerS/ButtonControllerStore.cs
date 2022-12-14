using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerStore : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private Button btnBuyDouble;
    [SerializeField] private Button btnBuyFifty;
    [SerializeField] private Button btnBuyPass;
    [SerializeField] private GameObject coinDisplay;
    [SerializeField] private GameObject doubleDisplay;
    [SerializeField] private GameObject fiftyDisplay;
    [SerializeField] private GameObject passDisplay;
    private int coinAmount;
    private int doubleAmount;
    private int fiftyAmount;
    private int passAmount;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
        btnBuyDouble.onClick.AddListener(TaskOnClick1);
        btnBuyFifty.onClick.AddListener(TaskOnClick2);
        btnBuyPass.onClick.AddListener(TaskOnClick3);
    }

    void Update()
    {
        coinAmount = PlayerPrefs.GetInt("CoinAmount");
        fiftyAmount = PlayerPrefs.GetInt("FiftyAmount");
        passAmount = PlayerPrefs.GetInt("PassAmount");
        doubleAmount = PlayerPrefs.GetInt("DoubleAmount");
        coinDisplay.GetComponent<Text>().text = "Coin : " + coinAmount;
        doubleDisplay.GetComponent<Text>().text = "Amount : " + doubleAmount;
        fiftyDisplay.GetComponent<Text>().text = "Amount : " + fiftyAmount;
        passDisplay.GetComponent<Text>().text = "Amount : " + passAmount;
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }

    void TaskOnClick1()
    {
        if(coinAmount >= 20)
        {
            doubleAmount++;
            coinAmount = coinAmount - 20;
            PlayerPrefs.SetInt("CoinAmount", coinAmount);
            PlayerPrefs.SetInt("DoubleAmount", doubleAmount);
        }
    }

    void TaskOnClick2()
    {
        if(coinAmount >= 25)
        {
            fiftyAmount++;
            coinAmount = coinAmount - 25;
            PlayerPrefs.SetInt("CoinAmount", coinAmount);
            PlayerPrefs.SetInt("FiftyAmount", fiftyAmount);
        }
    }

    void TaskOnClick3()
    {
        if(coinAmount >= 30)
        {
            passAmount++;
            coinAmount = coinAmount - 30;
            PlayerPrefs.SetInt("CoinAmount", coinAmount);
            PlayerPrefs.SetInt("PassAmount", passAmount);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerMenu : MonoBehaviour
{
    [SerializeField] private Button btnSinifSecim;
    [SerializeField] private Button btnLeaderBoard;
    [SerializeField] private Button btnStore;
    [SerializeField] private GameObject coinDisplay;
    [SerializeField] private Text menuText;
    private int coinAmount;
    private string username;
    // Start is called before the first frame update
    void Start()
    {
        username = PlayerPrefs.GetString("username");
        btnSinifSecim.onClick.AddListener(TaskOnClick);
        btnLeaderBoard.onClick.AddListener(TaskOnClick1);
        btnStore.onClick.AddListener(TaskOnClick2);
        coinAmount = PlayerPrefs.GetInt("CoinAmount");
        coinDisplay.GetComponent<Text>().text = "Coin Miktari : " + coinAmount;
        menuText.text = "Hosgeldin " + username + "!";
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SinifSecim");
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene("Store");
    }

}

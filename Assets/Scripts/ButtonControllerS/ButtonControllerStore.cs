using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerStore : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private GameObject coinDisplay;
    private int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
        coinAmount = PlayerPrefs.GetInt("CoinAmount");
        coinDisplay.GetComponent<Text>().text = "Coin Miktari : " + coinAmount;
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}

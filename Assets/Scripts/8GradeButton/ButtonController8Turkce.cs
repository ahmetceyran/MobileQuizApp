using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController8Turkce : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private Button btnSozcukteAnlam;
    [SerializeField] private Button btnCumledeAnlam;

    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
        btnSozcukteAnlam.onClick.AddListener(TaskOnClick01);
        btnCumledeAnlam.onClick.AddListener(TaskOnClick02);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DersSecim8");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("SozcukteAnlam");
    }

    void TaskOnClick02()
    {
        SceneManager.LoadScene("CumledeAnlam");
    }
}

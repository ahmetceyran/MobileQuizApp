using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController12Ders : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private Button btnMat;
    [SerializeField] private Button btnDilEdebiyat;

    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
        btnMat.onClick.AddListener(TaskOnClick01);
        btnDilEdebiyat.onClick.AddListener(TaskOnClick02);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SinifSecim");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("12MatKonuSecim");
    }

    void TaskOnClick02()
    {
        SceneManager.LoadScene("12DilEdebiyatKonuSecim");
    }
}

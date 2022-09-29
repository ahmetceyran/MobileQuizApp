using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController8Math : MonoBehaviour
{
    [SerializeField] private Button btnback;
    [SerializeField] private Button btnUsluSayilar;
    [SerializeField] private Button btnKokluSayilar;

    // Start is called before the first frame update
    void Start()
    {
        btnback.onClick.AddListener(TaskOnClick);
        btnUsluSayilar.onClick.AddListener(TaskOnClick01);
        btnKokluSayilar.onClick.AddListener(TaskOnClick02);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DersSecim8");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("UsluSayilar");
    }

    void TaskOnClick02()
    {
        SceneManager.LoadScene("KokluSayilar");
    }
}

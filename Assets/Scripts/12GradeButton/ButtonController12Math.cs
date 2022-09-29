using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController12Math : MonoBehaviour
{
    [SerializeField] private Button btnback;
    [SerializeField] private Button btnLogaritma;
    [SerializeField] private Button btnDiziler;

    // Start is called before the first frame update
    void Start()
    {
        btnback.onClick.AddListener(TaskOnClick);
        btnLogaritma.onClick.AddListener(TaskOnClick01);
        btnDiziler.onClick.AddListener(TaskOnClick02);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DersSecim12");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("Logaritma");
    }

    void TaskOnClick02()
    {
        SceneManager.LoadScene("Diziler");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControllerSinifSecim : MonoBehaviour
{
    [SerializeField] private Button btn8;
    [SerializeField] private Button btn12;

    // Start is called before the first frame update
    void Start()
    {
        btn8.onClick.AddListener(TaskOnClick);
        btn12.onClick.AddListener(TaskOnClick01);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DersSecim8");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("DersSecim12");
    }
}

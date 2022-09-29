using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurkceSoruEkraniGeri12 : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("12DilEdebiyatKonuSecim");
    }
}

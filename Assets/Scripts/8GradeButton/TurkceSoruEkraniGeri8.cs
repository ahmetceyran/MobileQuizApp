using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurkceSoruEkraniGeri8 : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("8TurkceKonuSecim");
    }
}

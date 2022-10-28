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
    // Start is called before the first frame update
    void Start()
    {
        btnSinifSecim.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SinifSecim");
    }

}

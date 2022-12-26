using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPage : MonoBehaviour
{
    [SerializeField] private Button btnLogin;
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("username");
        if(PlayerPrefs.HasKey("username"))
        {
            SceneManager.LoadScene("Menu");
        }else{
            PlayerPrefs.DeleteAll();
        }
        btnLogin.onClick.AddListener(TaskOnClick);
    }

    public void ReadStringInput(string s)
    {
        input = s;
    }

    void TaskOnClick()
    {
        Debug.Log(input);
        PlayerPrefs.SetString("username",input);
        SceneManager.LoadScene("Menu");
    }
}

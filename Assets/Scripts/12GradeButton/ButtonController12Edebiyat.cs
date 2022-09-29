using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController12Edebiyat : MonoBehaviour
{
    [SerializeField] private Button btnback;
    [SerializeField] private Button btnIletisim;
    [SerializeField] private Button btnSozcukVeSozObekleri;

    // Start is called before the first frame update
    void Start()
    {
        btnback.onClick.AddListener(TaskOnClick);
        btnIletisim.onClick.AddListener(TaskOnClick01);
        btnSozcukVeSozObekleri.onClick.AddListener(TaskOnClick02);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("DersSecim12");
    }

    // Update is called once per frame
    void TaskOnClick01()
    {
        SceneManager.LoadScene("IletisimDil");
    }

    void TaskOnClick02()
    {
        SceneManager.LoadScene("SozcukteVeSozObeklerindeAnlam");
    }
}

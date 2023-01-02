using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PlayFab;
using PlayFab.ClientModels;

public class ButtonControllerLeaderBoard : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private GameObject rowPrefab;
    [SerializeField] private Transform rowsParent;
    [SerializeField] private Text IdText;

    // Start is called before the first frame update
    void Start()
    {
        Login();
        StartCoroutine(WaitAndPrintLeaderboard());
        btnBack.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }

    void Login(){
        var request = new LoginWithCustomIDRequest{
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSucces,OnError);
    }

    void OnSucces(LoginResult result){
        Debug.Log("successful login/account created");
    }
    void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/account create");
    }

    private IEnumerator WaitAndPrintLeaderboard()
    {
        yield return new WaitForSeconds(0.5f);
        GetLeaderboard();
    }

    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest{
            StatisticName = "BestScore",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }

    void OnLeaderboardGet(GetLeaderboardResult result)
    { 
        foreach(var item in result.Leaderboard)
        {
            int positionCorrection = item.Position+1;
            GameObject newGo = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();
            texts[0].text = positionCorrection.ToString();
            texts[1].text = item.PlayFabId;
            texts[2].text = item.StatValue.ToString();
            IdText.text = "Your ID: " + item.PlayFabId;
            Debug.Log(string.Format("PLACE: {0} | ID: {1} | VALUE: {2}",positionCorrection + " " + item.PlayFabId + " " + item.StatValue));
        }
    }
}

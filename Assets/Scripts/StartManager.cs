using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
# endif

public class StartManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = $"Best Score: {DataKeeper.Instance.HighScoreName} : {DataKeeper.Instance.HighScore}";
        inputField.text = DataKeeper.Instance.HighScoreName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        DataKeeper.Instance.Name = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
# endif
    }
}

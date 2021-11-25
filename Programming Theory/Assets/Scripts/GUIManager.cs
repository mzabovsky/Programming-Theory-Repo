using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{

    [SerializeField] private TMP_InputField playerNameInputField;

    public static string playerName { get; private set; }
    public static GUIManager guiManager;


    // Start is called before the first frame update
    void Start()
    {
        if (guiManager == null)
        {
            guiManager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadPlayerName()
    {
        playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{

    public static GUIManager guiManagerInstance;

    [SerializeField] private TMP_InputField playerNameInputField;
    public string playerName { get; private set; }
    


    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        if (guiManagerInstance != null)
        {
            Destroy(gameObject);
            return;
        }

        guiManagerInstance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadPlayerName()
    {
        GUIManager.guiManagerInstance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }


}

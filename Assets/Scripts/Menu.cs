using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void OnStartGame() {
        InputField inputField = GameObject.FindObjectOfType<InputField>();
        string name = inputField.text;

        // save the name
        StaticManager.Instance.PlayerName = name;
        // change the scene
        SceneManager.LoadScene(1);
    }
}

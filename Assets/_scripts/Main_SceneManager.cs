using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_SceneManager : MonoBehaviour
{
    [SerializeField] GameObject _attractScreen;
    [SerializeField] GameObject _shopScreen;
    [SerializeField] GameObject _scoreScreen;

    public string _currentScene { get; private set; }

    private void Start()
    {
        _currentScene = "attract";
    }

    public void ChangeScene(string _scene)
    {
        switch (_scene)
        {
            case "attract":
                _attractScreen.SetActive(true);
                _shopScreen.SetActive(false);
                _scoreScreen.SetActive(false);
                break;
            case "shop":
                _attractScreen.SetActive(false);
                _shopScreen.SetActive(true);
                _scoreScreen.SetActive(false);
                break;
            case "score":
                _attractScreen.SetActive(false);
                _shopScreen.SetActive(false);
                _scoreScreen.SetActive(true);
                break;
        }
    }
}

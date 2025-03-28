using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.IO;

public class Main_SceneManager : MonoBehaviour
{
    [SerializeField] private GameObject _attractScreen;
    [SerializeField] private GameObject _shopScreen;
    [SerializeField] private GameObject _scoreScreen;
    [SerializeField] private GameObject _instructionScreen;
    [SerializeField] private Image _fadeImage;

    public string _currentScene { get; private set; }

    private void Start()
    {
        _currentScene = "attract";
    }

    public void ChangeScene(string _scene)
    {
        StartCoroutine(TurnOfAllWindows(_scene));
    }

    private IEnumerator TurnOfAllWindows(string _scene)
    {
        _fadeImage.DOFade(1, 1);

        yield return new WaitForSeconds(1);

        _attractScreen.SetActive(false);
        _instructionScreen.SetActive(false);
        _shopScreen.SetActive(false);
        _scoreScreen.SetActive(false);

        switch (_scene)
        {
            case "attract":
                _attractScreen.SetActive(true);
                break;
            case "intro":
                _instructionScreen.SetActive(true);
                break;
            case "shop":
                _shopScreen.SetActive(true);
                break;
            case "score":
                _scoreScreen.SetActive(true);
                break;
        }

        _fadeImage.DOFade(0, 1);

        yield return null;
    }
}

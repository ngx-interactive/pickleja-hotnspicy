using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using DG.Tweening;
using UnityEngine.UI;

public class Game_NextStep : MonoBehaviour
{
    [SerializeField] private GameObject _breadSelection;
    [SerializeField] private GameObject _ingredientSelection;
    [SerializeField] private GameObject _sauceSelection;
    [SerializeField] private GameObject _sandwichResults;
    [SerializeField] private Slider _progressSlider;
    [SerializeField] private GameObject[] _dots;

    public string _currentScene = "ingredient";

    private void OnEnable()
    {
        _dots[0].SetActive(true);
        _dots[1].SetActive(false);
        _dots[2].SetActive(false);
        _currentScene = "ingredient";
    }

    public void ChangePage()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        switch(_currentScene)
        {
            case "bread":
                _progressSlider.value = 0;
                _breadSelection.SetActive(true);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                _currentScene = "ingredient";
                break;
            case "ingredient":
                _progressSlider.value = 0.5f;
                _dots[1].SetActive(true);
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(true);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                _currentScene = "sauce";
                break;
            case "sauce":
                _progressSlider.value = 1;
                _dots[2].SetActive(true);
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(true);
                _sandwichResults.SetActive(false);
                _currentScene = "results";
                break;
            case "results":
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(true);
                break;
        }

        yield return null;
    }
}

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

    private void OnEnable()
    {
        _dots[0].SetActive(true);
        _dots[1].SetActive(false);
        _dots[2].SetActive(false);
    }

    public void ChangePage(string _page)
    {
        StartCoroutine(ChangeScene(_page));
    }

    private IEnumerator ChangeScene(string _page)
    {
        switch(_page)
        {
            case "bread":
                _progressSlider.value = 0;
                _breadSelection.SetActive(true);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                break;
            case "ingredient":
                _progressSlider.value = 0.5f;
                _dots[1].SetActive(true);
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(true);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                break;
            case "sauce":
                _progressSlider.value = 1;
                _dots[2].SetActive(true);
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(true);
                _sandwichResults.SetActive(false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using DG.Tweening;

public class Game_NextStep : MonoBehaviour
{
    [SerializeField] private GameObject _breadSelection;
    [SerializeField] private GameObject _ingredientSelection;
    [SerializeField] private GameObject _sauceSelection;
    [SerializeField] private GameObject _sandwichResults;

    public void ChangePage(string _page)
    {
        StartCoroutine(ChangeScene(_page));
    }

    private IEnumerator ChangeScene(string _page)
    {
        switch(_page)
        {
            case "bread":
                _breadSelection.SetActive(true);
                _ingredientSelection.SetActive(false);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                break;
            case "ingredient":
                _breadSelection.SetActive(false);
                _ingredientSelection.SetActive(true);
                _sauceSelection.SetActive(false);
                _sandwichResults.SetActive(false);
                break;
            case "sauce":
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

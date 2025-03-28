using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_AddIngredient : MonoBehaviour
{
    [SerializeField] private GameObject _ingredientHolder;
    [SerializeField] private GameObject _ingredientPlaceholder;

    [SerializeField] private Sprite _bread1;
    [SerializeField] private Sprite _bread2;
    [SerializeField] private Sprite _bread3;


    public void AddIngredient(string _ingredient)
    {
        if (_ingredientHolder.transform.childCount <= 10)
        {
            GameObject _tempGO = Instantiate(_ingredientPlaceholder, _ingredientHolder.transform);
            Image _tempImg = _tempGO.GetComponent<Image>();

            switch (_ingredient)
            {
                case "bread1":
                    _tempImg.sprite = _bread1;
                    break;
                case "bread2":
                    _tempImg.sprite = _bread2;
                    break;
                case "bread3":
                    _tempImg.sprite = _bread3;
                    break;
            }

            _tempImg.SetNativeSize();
        }
    }
}

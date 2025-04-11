using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_AddIngredient : MonoBehaviour
{
    [SerializeField] private Game_IngredientData _ingData;
    [SerializeField] private GameObject _ingredientHolder;
    [SerializeField] private GameObject _ingredientPlaceholder;

    [SerializeField] private Sprite _bread1;
    [SerializeField] private Sprite _bread2;
    [SerializeField] private Sprite _bread3;

    private float _offsetY;

    private void OnEnable()
    {
        _offsetY = 50;
    }


    public void AddIngredient(string _ingredient)
    {
        if (_ingredientHolder.transform.childCount <= 10)
        {
            GameObject _tempGO = Instantiate(_ingredientPlaceholder, _ingredientHolder.transform);
            Image _tempImg = _tempGO.GetComponent<Image>();
            Sprite _tmpSprite = _ingData._ingredientDatabase[_ingredient]._sprite;
            _tempImg.sprite = _tmpSprite;
            Vector3 _tmpPos = _tempGO.transform.localPosition;

            _tempImg.SetNativeSize();

            _tempGO.transform.localPosition = new Vector3(_tmpPos.x, _tmpPos.y + _offsetY, _tmpPos.z);
            _offsetY += 50;
        }
    }
}

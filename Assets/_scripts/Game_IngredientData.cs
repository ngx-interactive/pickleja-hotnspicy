using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_IngredientData : MonoBehaviour
{
    public struct Ingredient
    {
        public string _type;
        public Sprite _sprite;
        public string _tag1;
        public string _tag2;
        public string _tag3;
    }

    [SerializeField] private Sprite[] _breadSpritesList;
    [SerializeField] private Sprite[] _toppingSpritesList;
    [SerializeField] private Sprite[] _sauceSpritesList;

    Dictionary<string, Ingredient> _ingredientDatabase;

    private void Start()
    {
        _ingredientDatabase = new Dictionary<string, Ingredient>();
        SeedDatabase();
    }

    private void SeedDatabase()
    {
        //breads
        _ingredientDatabase.Add("bagel", 
            new Ingredient { _type = "bread",
                _sprite = _breadSpritesList[0],
                _tag1 = "",
                _tag2 = "",
                _tag3 = "" });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[1],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[2],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });

        //toppings
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });

        //sauces
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
        _ingredientDatabase.Add("bagel",
        new Ingredient
        {
            _type = "",
            _sprite = _breadSpritesList[0],
            _tag1 = "",
            _tag2 = "",
            _tag3 = ""
        });
    }
}

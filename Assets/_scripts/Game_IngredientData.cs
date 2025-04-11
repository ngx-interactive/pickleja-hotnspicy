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

    public Dictionary<string, Ingredient> _ingredientDatabase;

    private void Start()
    {
        _ingredientDatabase = new Dictionary<string, Ingredient>();
        SeedDatabase();
    }

    private void SeedDatabase()
    {
        //breads
        _ingredientDatabase.Add("Bagel",
            new Ingredient
            {
                _type = "bread",
                _sprite = _breadSpritesList[0],
                _tag1 = "Holey",
                _tag2 = "Sweet",
                _tag3 = "Magical"
            });
        _ingredientDatabase.Add("Sourdough",
        new Ingredient
        {
            _type = "bread",
            _sprite = _breadSpritesList[1],
            _tag1 = "Tangy",
            _tag2 = "Healthy",
            _tag3 = "Crunchy"
        });
        _ingredientDatabase.Add("Multigrain",
        new Ingredient
        {
            _type = "bread",
            _sprite = _breadSpritesList[2],
            _tag1 = "Healthy",
            _tag2 = "Earthy",
            _tag3 = "Classic"
        });

        //toppings
        _ingredientDatabase.Add("Cheese",
        new Ingredient
        {
            _type = "topping",
            _sprite = _toppingSpritesList[0],
            _tag1 = "Holey",
            _tag2 = "Classic",
            _tag3 = "Tangy"
        });
        _ingredientDatabase.Add("Lettuce",
        new Ingredient
        {
            _type = "topping",
            _sprite = _toppingSpritesList[1],
            _tag1 = "Crunchy",
            _tag2 = "Healthy",
            _tag3 = "Classic"
        });
        _ingredientDatabase.Add("Egg",
        new Ingredient
        {
            _type = "topping",
            _sprite = _toppingSpritesList[3],
            _tag1 = "Gooey",
            _tag2 = "Healthy",
            _tag3 = "Classic"
        });
        _ingredientDatabase.Add("Pickle",
        new Ingredient
        {
            _type = "toping",
            _sprite = _toppingSpritesList[2],
            _tag1 = "Crunchy",
            _tag2 = "Tangy",
            _tag3 = "Moist"
        });
        _ingredientDatabase.Add("Glitter",
        new Ingredient
        {
            _type = "topping",
            _sprite = _toppingSpritesList[4],
            _tag1 = "Magical",
            _tag2 = "Sweet",
            _tag3 = "Silly"
        });
        _ingredientDatabase.Add("Mushroom",
        new Ingredient
        {
            _type = "toping",
            _sprite = _toppingSpritesList[5],
            _tag1 = "Magical",
            _tag2 = "Moist",
            _tag3 = "Silly"
        });

        //sauces
        _ingredientDatabase.Add("Mustard",
        new Ingredient
        {
            _type = "sauce",
            _sprite = _sauceSpritesList[0],
            _tag1 = "Tangy",
            _tag2 = "Moist",
            _tag3 = "Classic"
        });
        _ingredientDatabase.Add("Mayo",
        new Ingredient
        {
            _type = "sauce",
            _sprite = _sauceSpritesList[1],
            _tag1 = "Classic",
            _tag2 = "Tangy",
            _tag3 = "Gooey"
        });
        _ingredientDatabase.Add("Hotsauce",
        new Ingredient
        {
            _type = "sauce",
            _sprite = _sauceSpritesList[2],
            _tag1 = "Holey",
            _tag2 = "Spicy",
            _tag3 = "Moist"
        });
        _ingredientDatabase.Add("Jam",
        new Ingredient
        {
            _type = "sauce",
            _sprite = _sauceSpritesList[3],
            _tag1 = "Gooey",
            _tag2 = "Sweet",
            _tag3 = "Silly"
        });
    }
}

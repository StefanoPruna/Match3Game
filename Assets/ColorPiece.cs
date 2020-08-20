using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPiece : MonoBehaviour
{
    public enum ColorType
    {
        YELLOW,
        PURPLE,
        RED,
        BLUE,
        GREEN,
        PINK,
        ANY,
        COUNT
    };

    [System.Serializable]
    public struct ColorSprite
    {
        public ColorType color;
        public Sprite sprite;
    };

    public ColorSprite[] colorSprites;

    private Dictionary<ColorType, Sprite> colorSpriteDict;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

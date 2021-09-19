using UnityEngine;

public class PieceColor : MonoBehaviour
{
    
    

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite blueColor = null;
    [SerializeField] private Sprite redColor = null;
    [SerializeField] private Sprite greenColor = null;
    [SerializeField] private Sprite purpleColor = null;
    [SerializeField] private Sprite goldColor = null;
    [SerializeField] private Sprite greyColor = null;
    [SerializeField] private Sprite brownColor = null;
    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {

        int color = Random.Range(0, 7);
        if (color == 0) spriteRenderer.sprite = blueColor;
        if (color == 1) spriteRenderer.sprite = redColor;
        if (color == 2) spriteRenderer.sprite = greenColor;
        if (color == 3) spriteRenderer.sprite = purpleColor;
        if (color == 4) spriteRenderer.sprite = goldColor;
        if (color == 5) spriteRenderer.sprite = greyColor;
        if (color == 6) spriteRenderer.sprite = brownColor;

        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above

        //spriteRenderer.sprite = ???

    }

}

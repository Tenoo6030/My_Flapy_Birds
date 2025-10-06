using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Device;

public class Level : MonoBehaviour
{
    private const float COLUMN_WIDTH = 8.6f;
    private const float HALF_SIZE_SCREEN = 50F;
    //private const float COLUMN_HEAD_HEIGHT = 6.45F;


    private void Start()
    {
        CreateColumn(35f, 0f);
        CreateColumn(50f, 30f);
        CreateColumn(25f, 60f);
        CreateColumn(15f, 90f);
        CreateColumn(45f, 120f);
    }

    private void CreateColumn(float height, float xPosition)
    {
        //Creating a column head and positioning it
        Transform columnHead = Instantiate(GameAssets.GetInstance.prefColumnHead);
        columnHead.position = new(xPosition, -HALF_SIZE_SCREEN + height, 0);

        //Creating a column body and positioning it
        Transform columnBody = Instantiate(GameAssets.GetInstance.prefcColumnBody);
        columnBody.position = new(xPosition, -HALF_SIZE_SCREEN, 0);
        SpriteRenderer colmnBodySpriteRenderer = columnBody.GetComponent<SpriteRenderer>();
        colmnBodySpriteRenderer.size = new(COLUMN_WIDTH, height);
    }
}

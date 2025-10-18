using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const float COLUMN_WIDTH = 8.6f;
    private const int HALF_SIZE_SCREEN = 50;

    // private List

    private void Start()
    {
        CreatingObstacle(25, 20f, 0);
        CreatingObstacle(0, 20f, 50f);

    }
    private void CreatingObstacle(float gapY, float gapSize, float xPosition)
    {
        float halfGap = gapSize * 0.5f;
        CreateColumn(xPosition, gapY - halfGap, true);
        CreateColumn(xPosition, gapY + halfGap, false);

    }

    private void CreateColumn(float xPosition, float yPosition, bool onGround)
    {

        //Creating a column head and positioning it
        Transform columnHead = Instantiate(GameAssets.GetInstance.prefColumnHead);
        columnHead.position = new(xPosition, yPosition, 0);
        columnHead.localScale = onGround ? Vector3.one : new(1, -1, 1);

        //Creating a column body and positioning it
        Transform columnBody = Instantiate(GameAssets.GetInstance.prefColumnBody);
        columnBody.position = new(xPosition, yPosition, 0);
        SpriteRenderer colmnBodySpriteRenderer = columnBody.GetComponent<SpriteRenderer>();
        columnBody.localScale = onGround ? new(1, -1, 1) : Vector3.one;
        float height = onGround ? yPosition + HALF_SIZE_SCREEN : HALF_SIZE_SCREEN - yPosition;
        colmnBodySpriteRenderer.size = new(COLUMN_WIDTH, height);
    }

}
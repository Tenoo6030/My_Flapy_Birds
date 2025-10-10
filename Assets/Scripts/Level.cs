using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const float COLUMN_WIDTH = 8.6f;
    private const float HALF_SIZE_SCREEN = 50F;
    // private List

    private void Start()
    {
        CreatingObstacle(75f, 35f, 0);
        CreatingObstacle(75f, 35f, 50f);

    }
    private void CreatingObstacle(float gapY, float gapSize, float xPosition)
    {
        float HalfGap = gapSize * 0.5f;
        CreateColumn(gapY - HalfGap, xPosition, false);
        CreateColumn(HALF_SIZE_SCREEN * 2f - gapY - HalfGap, xPosition, true);
    }

    private void CreateColumn(float height, float xPosition, bool onGround)
    {
        float yPosition = onGround ? -HALF_SIZE_SCREEN + height : HALF_SIZE_SCREEN - height;

        //Creating a column head and positioning it
        Transform columnHead = Instantiate(GameAssets.GetInstance.prefColumnHead);
        columnHead.position = new(xPosition, yPosition, 0);
        columnHead.localScale = onGround ? Vector3.one : new(1, -1, 1);

        //Creating a column body and positioning it
        Transform columnBody = Instantiate(GameAssets.GetInstance.prefColumnBody);
        columnBody.position = new(xPosition, yPosition, 0);
        SpriteRenderer colmnBodySpriteRenderer = columnBody.GetComponent<SpriteRenderer>();
        columnBody.localScale = onGround ? new(1, -1, 1) : Vector3.one;
        colmnBodySpriteRenderer.size = new(COLUMN_WIDTH, height);
    }

}
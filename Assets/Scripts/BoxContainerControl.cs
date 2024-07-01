using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxContainerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeCreateEnemy = 2;
    protected float timeCurrentCreateEnemy = 0;
    public float minX;
    public float maxX;
    public float yPosition;
    void CreateBox()
    {
        float xPosition = Random.Range(minX, maxX);
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        GameObject enemy = Instantiate(enemyPrefab, positionToCreate, transform.rotation);
    }
    void Update()
    {
        timeCurrentCreateEnemy = timeCurrentCreateEnemy + Time.deltaTime;
        if (timeCurrentCreateEnemy >= timeCreateEnemy)
        {
            timeCurrentCreateEnemy = 0;
            CreateBox();
        }
    }
}

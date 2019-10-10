using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Starter : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private GameObject cell;
    [SerializeField] private int column;
    [SerializeField] private int row;
    [SerializeField] private float gap;

    private void Start()
    {
        LevelGenerator();
        RandomCharacterSpawn();
    }

    private void LevelGenerator()
    {
        for (int c = 0; c < column; c++)
        {
            for (int r = 0; r < row; r++)
            {
                Vector3 position = new Vector3(r * gap, c * gap, 0f);
                Instantiate(cell, position, Quaternion.identity);
            }
        }
    }

    private void RandomCharacterSpawn()
    {
        Vector3 postion = new Vector3(Random.Range(0, row) * gap, Random.Range(0, column) * gap, -1f);
        Character chrt = Instantiate(character, postion, Quaternion.identity);
        chrt.Init(column, row, gap);
    }
}
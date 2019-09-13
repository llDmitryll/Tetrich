using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetromino : MonoBehaviour
{
    // публичный массив со всеми фигурами (префабами)
    // изначально он пустой, и из редактора мы его наполняем
    public GameObject[] Tetrominoes;

    // Start вызывается до первого нарисованного кадра один раз
    void Start()
    {
        // Вызываем новую фигуру один раз в самом начале
        // Все последующие разы эту функцию вызываем из старой фигуры (предыдущей новой)
        // Когда старая фигура зафиксировалась в пространстве и пора рисовать новую
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}

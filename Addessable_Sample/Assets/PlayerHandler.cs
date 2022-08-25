using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    private void Move()
    {
        int direction = Random.Range(0, 4);
        Debug.LogError("scripts change");
        var moveDirection = direction switch
        {
            0 => Vector3.up,
            1 => Vector3.right,
            2 => Vector3.down,
            3 => Vector3.left
        };

        transform.DOMove(transform.position + moveDirection, 1).OnComplete(Move);
    }
}

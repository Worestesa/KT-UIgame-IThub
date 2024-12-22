using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiAttack : MonoBehaviour
{
    public float radius;
    public float timeAttack;
    public float DPS;
    [SerializeField] Transform gamer;

    private float _timer;

    private void Update()
    {
        Vector2 vectorRadius = new Vector2(Math.Abs(transform.position.x - gamer.position.x), Math.Abs(transform.position.y - gamer.position.y));

        float distance = MathF.Sqrt(vectorRadius.x * vectorRadius.x + vectorRadius.y + vectorRadius.y);

        if (distance <= radius)
        {
            _timer += Time.deltaTime;
            if (_timer > timeAttack)
            {
                gamer.GetComponentInChildren<PlayrHP>().DPSPlayer(DPS);
                _timer = 0;
            }
        }
        else
        {
            _timer = 0;
        }
    }
}

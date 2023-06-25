using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 5f;  // 적의 이동 속도
    private GameObject player;    // 플레이어 오브젝트

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");  // 플레이어 오브젝트를 태그로 찾아서 할당
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.transform.position - transform.position;  // 플레이어 방향 계산
            direction.Normalize();  // 방향 벡터를 정규화

            transform.Translate(direction * moveSpeed * Time.deltaTime);  // 적을 플레이어 방향으로 이동
        }
    }
}
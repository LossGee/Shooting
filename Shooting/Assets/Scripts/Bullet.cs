using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �Ѿ��� ��� ���� �̵��ϰ� �ʹ� 
// 1. ���� ���ϱ�
// 2. �̵��ϱ�
public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ���� ���ϱ�
        Vector3 dir = Vector3.up;

        // 2. �̵��ϱ� 
        transform.position += dir * speed * Time.deltaTime;
    }
}

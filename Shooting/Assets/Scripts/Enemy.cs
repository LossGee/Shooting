using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[proto]
step1 : �Ʒ��� ��� �̵��ϰ� �ʹ�. 
    1. ���� ���ϱ�
    2. �̵��ϱ� 

step2 : Enemy�� � ��ü�� �浹�ϸ� �� �� �ı��ϰ� �ʹ�. 
    
step3 : 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��������� ���ϰ� �ʹ�.
        = 0���� 9���� 10���� �� �߿� �ϳ��� �������� �����´�. 
          ����, �� ���� 3���� ������ �÷��̾� ��������,
          �׷��� ������, �Ʒ� �������� �̵��Ѵ�. 
    1. 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ� ����
    2. �¾ �� ������ ���ϰ� �� �������� ��� �̵�


[alpha]
 - ��ǥ: ���� �ٸ� ��ü�� �浹���� �� ����ȿ���� �߻���Ű�� �ʹ�. 
 - ����: 1. ���� �ٸ� ��ü�� �浹�����ϱ�
         2. ���� ȿ�� ���忡�� ����ȿ���� �ϳ� ������ �Ѵ�. 
         3. ���� ȿ���� �߻�(��ġ)��Ű�� �ʹ�. 
 - �ʿ�Ӽ�: ���� ���� �ּ�(�ܺο��� ���� �־��ش�)
 */

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    Vector3 dir;
    public GameObject explosionFactory; 

    // Start is called before the first frame update
    void Start()
    {
        // 0~9���� 1���� ���� �������� �����´�. 
        int randValue = UnityEngine.Random.Range(0, 9);

        // ����, �� ���� 3���� ������ �÷��̾��� �������� ����
        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");          // target ã��
            if (target != null)
            { 
                dir = target.transform.position - transform.position;   // ����: target - ����ġ����
                dir.Normalize();
            }
            else
                dir = Vector3.down;
        }
        // �׷��� ������ �Ʒ� �������� ����
        else 
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // step1 : �Ʒ��� ��� �̵��ϰ� �ʹ�. 
        // 1. ���� ���ϱ�
        //Vector3 dir = Vector3.down;       // dir�� �ʵ�� ���
        //print("Magnitude of dir: " + dir.magnitude);

        // 2. �̵��ϱ� 
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� ���忡�� ������ �ϳ� �����Ѵ�. 
        GameObject explosion = Instantiate(explosionFactory);
        // ���� ȿ���� �߻�(��ġ)��Ű�� �ʹ�. 
        explosion.transform.position = transform.position;

        // �� �װ�
        Destroy(collision.gameObject);
        // �� ����
        Destroy(gameObject);

        //
    }
    
}

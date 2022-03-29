using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �÷��̾ �̵���Ű�� �ʹ�.
// 1. ������� �Է�ó�� (�Է��� ��ǻ�Ϳ� ���δ�)
// 2. ���� ����� (�Է°��� ����Ͽ� �̵��� �ϼ�)
// 3. �÷��̾� �̵���Ű�� (Player�� �̵���Ų��.)
public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        // 1. ������� �Է� ó��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        // 2. ����[dir] ����� 
        //Vector3 dir = Vector3.right * h + Vector3.up * v;     // �������� �����ϱ� 
        
        Vector3 dir = new Vector3(h, v, 0);                     // ������ �������� �־� ���� ���̱�
        dir.Normalize();
        //print("Magnitude: " + dir.magnitude);

        // 3. �÷��̾� �̵���Ű�� + �̵� ���� �ɱ�
        //transform.Translate(dir * speed * Time.deltaTime);    // transform.Translate()  �Լ� �̿�
        //transform.position = transform.position + dir * speed * Time.deltaTime;     // P = P0 + vt ���� ����
        //transform.position += dir * speed * Time.deltaTime;     // ����� ��

        //+ �̵� ���� ���ѱ�� �߰�: Mathf.Clamp() Ȱ��
        Vector3 currentPos = transform.position;
        currentPos += dir * speed * Time.deltaTime;
        currentPos.x = Mathf.Clamp(currentPos.x, -3f, 3f);
        currentPos.y = Mathf.Clamp(currentPos.y, -5f, 5f);

        transform.position = currentPos;
         
    }
}

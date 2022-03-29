using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
step1) ���� �ð����� ���� ������ �� ��ġ�� ���� ���� �ʹ�. 
    1. �ð��� �帣�ٰ�
    2. ����, ����ð��� ���� �ð��� �Ǹ�
    3. �� ���忡�� ���� ������ �� ��ġ�� ���� ���� �ʹ�.(+����ð� �ʱ�ȭ)
step2) ���� ������ ������ ���� �����ð��� �����ϰ� �ٲٰ� �ʹ�. 
    1. �¾��, ���� �����ð��� �����ϰ�
    2. ���� ������ �� �����ð��� �ٽ� �����ϰ� �ʹ�. 
*/
public class EnemyManager : MonoBehaviour
{
    public float minTime = 0.5f;        // �� ���� �ּҽð�
    public float maxTime = 2.0f;        // �� ���� �ִ�ð�
    public float createTime = 1.0f;     // �����ð� 
    float currentTime = 0f;
    public GameObject enemyFactory;     // �� ���� 


    // Start is called before the first frame update
    void Start()
    {
        // �¾ ��, ���� �ð��� �����ϰ� 
        createTime = UnityEngine.Random.Range(minTime, maxTime);    // �����ð�(�����ϰ� ����)
    }

    // Update is called once per frame
    void Update()
    {
        // 1.�ð��� �帣�ٰ�
        currentTime += Time.deltaTime;

        // 2.����, ����ð��� ���� �ð��� �Ǹ�
        if(currentTime > createTime)
        {
            // 3.�� ���忡�� ���� ������ 
            GameObject enemy = Instantiate(enemyFactory);
            // �� ��ġ�� ���� ���� �ʹ�.
            enemy.transform.position = transform.position;
            // ����ð� �ʱ�ȭ
            currentTime = 0.0f;

            // ���� ������ �� �ٽ� �����ð��� �ٽ� �����ϰ� �ʹ�. 
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }



    }
}

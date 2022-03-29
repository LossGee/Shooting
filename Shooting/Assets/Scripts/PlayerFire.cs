using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����ڰ� �߻縦 ������ �Ѿ��� �߻�ȴ�. 
// 1. ����ڰ� �߻� ��ư�� ������
// 2. �Ѿ� ���忡�� �Ѿ��� �����Ѵ�.
// 3. �Ѿ��� �߻��Ѵ�. 
public class PlayerFire : MonoBehaviour
{
    // �Ѿ��� �����ϴ� ����
    public GameObject bulletFactory;
    // �ѱ�(�Ѿ��� ��ġ�� ��)
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ����ڰ� �߻� ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �Ѿ� ���忡�� �Ѿ��� �����Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);

            // 3. �Ѿ��� �߻��Ѵ�. 
            bullet.transform.position = firePosition.transform.position;
        }
    }

        
}

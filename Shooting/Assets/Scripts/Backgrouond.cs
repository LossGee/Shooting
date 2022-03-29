using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
way1) ��� ��ũ���� �ǵ��� �ϰ� �ʹ�. 
    1. ����ִ� ���� ��� �ϰ�ʹ�. 
    2. ������ �ʿ��ϴ� 
    3. ��ũ���ϰ�ʹ�.

way2) ��� ��ũ���� �ϰ� �ʹ�. 
    1. �¾ �� ������ ����ߴٰ� 
    2. ��ư��鼭 ������ offset���� ���� �̵��ϰ�ʹ�.
 */
public class Backgrouond : MonoBehaviour
{
    //public Material bgMaterial;       // way1) Material�� ���� �־��ִ� ���
    Material mat;                       // way2) Mesh Renderer �Ӽ��� �������� ���
    
    public float scrollSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // �¾�� ������ ����Ѵ�. 
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //2. ������ �ʿ��ϴ�.
        Vector2 direction = Vector2.up;

        //3. ��ũ���ϰ� �ʹ�. 
        //bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
        mat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}

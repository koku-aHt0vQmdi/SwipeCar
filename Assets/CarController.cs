using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //�X���C�v�̒��������߂�
        if (Input.GetMouseButtonDown(0))//�}�E�X���N���b�N���ꂽ��
        {
            //�}�E�X���N���b�N�������W
            this.startPos = Input.mousePosition;
        }else if (Input.GetMouseButtonUp(0))
        {
            //�}�E�X�𗣂������W
            Vector2 endPos = Input.mousePosition;
            float swipeLength = -(endPos.x - this.startPos.x);
            if(swipeLength >= 0)
                return;

            //�X���C�v�̒����������x�ɕϊ�����
            this.speed = swipeLength / 500.0f;

            //���ʉ��Đ�
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;

        Transform flag = this.transform;
        Vector3 pos = flag.position;
        if (pos.x <= -15f)
        {
            pos.x = 15f;
            flag.position = pos;
        }
            
    }
}

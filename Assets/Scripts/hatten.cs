using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatten : MonoBehaviour
{
    Boss boss;

    void Start()
    {
        boss = new Boss();

        //Magic�֐���10��Ăяo��
        for (int i = 0; i < 10; i++)
        {
            boss.Magic(5);
        }

        //mp������Ȃ��Ƃ���Magic�֐����Ăяo��
        boss.Magic(5);

    }

}

public class Boss
{
    private int mp = 53;          // MP

    // ���@�p�̊֐�
    public void Magic(int mp)
    {
        if (this.mp >= 5)
        {
            this.mp -= mp;
            Debug.Log("���@�U���������B�c��MP��" + this.mp +"�B");
        }
        else Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
    }

}
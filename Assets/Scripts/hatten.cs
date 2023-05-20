using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatten : MonoBehaviour
{
    Boss boss;

    void Start()
    {
        boss = new Boss();

        //Magic関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            boss.Magic(5);
        }

        //mpが足りないときにMagic関数を呼び出す
        boss.Magic(5);

    }

}

public class Boss
{
    private int mp = 53;          // MP

    // 魔法用の関数
    public void Magic(int mp)
    {
        if (this.mp >= 5)
        {
            this.mp -= mp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp +"。");
        }
        else Debug.Log("MPが足りないため、魔法が使えない。");
    }

}
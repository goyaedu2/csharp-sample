using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Break : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            while (true)
            {
                string answer = "y";

                if (answer == "y")
                {
                    break;
                }
            }
        }

        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Debug.Log($"{i} : Ȧ��");
            }
        }
    }

    void Sample()
    {
        while(true)
        {
            string item = GetMoo();
            if (item == "������")
                continue;
            if (item == "Ȳ�ݹ�")
                break;

            Collect(item);
        }
    }
}

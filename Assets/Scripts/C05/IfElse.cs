using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    // ȭ�鿡 ����� ����� Text
    public TMP_Text text;

    // ����ڿ��� �Է��� ���� Input Field
    public TMP_InputField inputFiled;

    // ��ư�� Ŭ�� �Ǿ��� �� ������ �Լ�
    public void ButtonClicked()
    {
        string input = inputFiled.text;
        int number = int.Parse(input);

        if (number < 0)
        {
            text.text = "����";
        }
        else if (number > 0)
        {
            text.text = "���";
        }
        else
        {
            text.text = "0";
        }

        if (number % 2 == 0)
        {
            text.text += " ¦��";
        }
        else
        {
            text.text += " Ȧ��";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ������

    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        // ���������� ����������� �������� �� ������ ������� ������
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }

        // ����������� ������, ����� �������� ���� ����������� ��� ������� ���������� ������
        inputVector = inputVector.normalized;

        // ���������� ������
        transform.Translate(new Vector3(inputVector.x, inputVector.y, 0) * moveSpeed * Time.deltaTime);
    }
}

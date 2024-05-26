//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
////using UnityEditor.Experimental.GraphView;
//using static Unity.Burst.Intrinsics.X86;

//public class step13move : MonoBehaviour
//{
//    // box1���� box?������ GameObject �迭
//    public GameObject[] boxes;
//    public GameObject selection;
//    public Button Button1;
//    public GameObject step13;
//    public GameObject step14;
//    public GameObject panel;

//    void Start()
//    {
//        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
//        StartCoroutine(ActivateAllBoxes());

//        // ��ư Ŭ�� ������ ���
//        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));

//        selection.SetActive(false);
//    }

//    // �迭 ��ü�� ���� SetActive�� ȣ���ؼ� box ��Ȱ��ȭ
//    void SetActiveAllBoxes(bool isActive)
//    {
//        foreach (var box in boxes)
//        {
//            box.SetActive(isActive);
//        }
//    }


//    IEnumerator ActivateAllBoxes()
//    {
//        // �迭�� �ִ� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
//        for (int i = 0; i < boxes.Length; i++)
//        {
//            // �ش� index�� box GameObject�� ������
//            GameObject box = boxes[i];

//            // ��ٸ���
//            yield return new WaitForSeconds(1f);

//            // box�� display�� Ȱ��ȭ
//            box.SetActive(true);

//        }


//        yield return new WaitForSeconds(2f);

//        // selection Ȱ��ȭ
//        selection.SetActive(true);

//    }


//    public void OnButtonClick1(GameObject selectedButton)
//    {
//        // step6 ��Ȱ��ȭ
//        step13.SetActive(false);

//        // step Ȱ��ȭ
//        step14.SetActive(true);

//        // step7�� RectTransform ������Ʈ�� ��������
//        RectTransform step14Rect = step14.GetComponent<RectTransform>();

//        // step7�� anchoredPosition�� (0, 0)���� ����
//        step14Rect.anchoredPosition = Vector2.zero;
//    }

//}



using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;
using System.Collections.Generic;

public class step13move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
    public GameObject[] boxes;
    public GameObject selection;
    public GameObject step9;
    public GameObject step10;
    public GameObject step11;
    public GameObject step12;
    public GameObject step13;
    public GameObject panel;

    public Text searchKeyword;
    public Dictionary<string, GameObject> keywordCollection = new Dictionary<string, GameObject>();
    public Button searchButton;

    void Start()
    {
        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        StartCoroutine(ActivateAllBoxes());

        selection.SetActive(false);

        // �ν����� â���� �Ҵ�� ��ư�� Ŭ�� ������ ���
        searchButton.onClick.AddListener(CheckAndMovePanel);
    }


    public void CheckAndMovePanel()
    {
        string keyword = searchKeyword.text.Trim();



        // keyword�� "�����"�� "����"�� ��� �����ϴ��� Ȯ��
        if (keyword.Contains("�����") && keyword.Contains("����"))
        {
            Debug.Log("9");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step9.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step9Rect = step9.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step9Rect.anchoredPosition = Vector2.zero;

        }

        if (keyword.Contains("����") && !(keyword.Contains("�����")))
        {
            Debug.Log("10");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step10.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("����") && !(keyword.Contains("�Ͽ���")))
        {
            Debug.Log("10");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step10.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("��") && !(keyword.Contains("�����")))
        {
            Debug.Log("10");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step10.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("��") && !(keyword.Contains("�Ͽ���")))
        {
            Debug.Log("10");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step10.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step10Rect = step10.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step10Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("�����") && keyword.Contains("��"))
        {
            Debug.Log("11");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step11.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step11Rect = step11.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step11Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("�Ͽ���") && keyword.Contains("����"))
        {
            Debug.Log("11");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step11.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step11Rect = step11.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step11Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("�����") && keyword.Contains("����"))
        {
            Debug.Log("12");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step12.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step12Rect = step12.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step12Rect.anchoredPosition = Vector2.zero;
        }

        if (keyword.Contains("�Ͽ���") && keyword.Contains("��"))
        {
            Debug.Log("13");
            // step14 ��Ȱ��ȭ
            step13.SetActive(false);

            // step7 Ȱ��ȭ
            step13.SetActive(true);

            // step7�� RectTransform ������Ʈ�� ��������
            RectTransform step13Rect = step13.GetComponent<RectTransform>();

            // step7�� anchoredPosition�� (0, 0)���� ����
            step13Rect.anchoredPosition = Vector2.zero;
        }

    }

    // �迭 ��ü�� ���� SetActive�� ȣ���ؼ� box ��Ȱ��ȭ
    void SetActiveAllBoxes(bool isActive)
    {
        foreach (var box in boxes)
        {
            box.SetActive(isActive);
        }
    }


    IEnumerator ActivateAllBoxes()
    {
        // �迭�� �ִ� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        for (int i = 0; i < boxes.Length; i++)
        {
            // �ش� index�� box GameObject�� ������
            GameObject box = boxes[i];

            // ��ٸ���
            yield return new WaitForSeconds(1f);

            // box�� display�� Ȱ��ȭ
            box.SetActive(true);

        }


        yield return new WaitForSeconds(2f);

        // selection Ȱ��ȭ
        selection.SetActive(true);

    }

}
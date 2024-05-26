using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step6move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    public GameObject step6;
    public GameObject step7;
    public GameObject step8;
    public GameObject panel;

    void Start()
    {
        // Start �޼��忡�� ��� box GameObject�� display�� Ȱ��ȭ�մϴ�.
        StartCoroutine(ActivateAllBoxes());

        // ��ư Ŭ�� ������ ���
        Button1.onClick.AddListener(() => OnButtonClick1(Button1.gameObject));
        Button2.onClick.AddListener(() => OnButtonClick2(Button2.gameObject));

        selection.SetActive(false);
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


    // ��ư Ŭ�� �� ȣ��� �޼���
    public void OnButtonClick1(GameObject selectedButton)
    {
        // step6 ��Ȱ��ȭ
        step6.SetActive(false);

        // step7 Ȱ��ȭ
        step7.SetActive(true);

        // step7�� RectTransform ������Ʈ�� ��������
        RectTransform step7Rect = step7.GetComponent<RectTransform>();

        // step7�� anchoredPosition�� (0, 0)���� ����
        step7Rect.anchoredPosition = Vector2.zero;

    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step6 ��Ȱ��ȭ
        step6.SetActive(false);

        // step8 Ȱ��ȭ
        step8.SetActive(true);

        // step8�� RectTransform ������Ʈ�� ��������
        RectTransform step8Rect = step8.GetComponent<RectTransform>();

        // step8�� anchoredPosition�� (0, 0)���� ����
        step8Rect.anchoredPosition = Vector2.zero;

    }

}
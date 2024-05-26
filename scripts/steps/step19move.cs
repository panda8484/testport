using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using static Unity.Burst.Intrinsics.X86;

public class step19move : MonoBehaviour
{
    // box1���� box?������ GameObject �迭
    public GameObject[] boxes;
    public GameObject selection;
    public Button Button1;
    public Button Button2;
    public GameObject step19;
    public GameObject step20;
    public GameObject step21;
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
        step19.SetActive(false);

        // step7 Ȱ��ȭ
        step20.SetActive(true);

        // step7�� RectTransform ������Ʈ�� ��������
        RectTransform step20Rect = step20.GetComponent<RectTransform>();

        // step7�� anchoredPosition�� (0, 0)���� ����
        step20Rect.anchoredPosition = Vector2.zero;

    }

    public void OnButtonClick2(GameObject selectedButton)
    {
        // step6 ��Ȱ��ȭ
        step19.SetActive(false);

        // step8 Ȱ��ȭ
        step21.SetActive(true);

        // step8�� RectTransform ������Ʈ�� ��������
        RectTransform step21Rect = step21.GetComponent<RectTransform>();

        // step8�� anchoredPosition�� (0, 0)���� ����
        step21Rect.anchoredPosition = Vector2.zero;

    }

}
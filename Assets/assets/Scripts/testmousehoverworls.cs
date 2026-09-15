using UnityEngine;

public class testmousehoverworls : MonoBehaviour
{
    private SpriteRenderer rend;
    public Color hoverColor = Color.red;
    public Color normalColor = Color.white;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = normalColor;
        Debug.Log("Скрипт успешно запущен на объекте: " + gameObject.name);
    }

    void OnMouseEnter()
    {
        Debug.Log("Курсор НАВЕДЁН на объект!");
        rend.color = hoverColor;
    }

    void OnMouseExit()
    {
        Debug.Log("Курсор УБРАН с объекта!");
        rend.color = normalColor;
    }
}
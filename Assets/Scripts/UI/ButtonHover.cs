using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] TextMeshProUGUI text;
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        text.fontStyle |= FontStyles.Underline;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        text.fontStyle &= ~FontStyles.Underline;

    }
}

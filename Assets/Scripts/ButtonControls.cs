using UnityEngine;
using UnityEngine.EventSystems;

public class Example : MonoBehaviour, IPointerClickHandler
{
    public string button_type;
    public CharacterController controller;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Vector3 move = Vector3.zero;
        float distance = 100f;

        switch (button_type)
        {
            case "up":
                move = transform.forward * distance;
                break;

            case "down":
                move = -transform.forward * distance;
                break;

            case "left":
                move = -transform.right * distance;
                break;

            case "right":
                move = transform.right * distance;
                break;
        }

        controller.Move(move * 2 * Time.deltaTime);
    }
}

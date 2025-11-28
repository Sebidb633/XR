using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool isDoorOpen = false;
    [SerializeField]
    private Vector3 doorRotation;
    [SerializeField]
    private Transform doorPivot;
    //[SerializeField]
    //private Vector3 doorRotationClose;

    private void OpenTheDoor()
    {
        doorPivot.Rotate(-doorRotation);
    }

    private void CloseDoor()
    {
        doorPivot.Rotate(doorRotation);
    }

    public void ToggleDoor()
    {
        isDoorOpen = !isDoorOpen;
        if (isDoorOpen)
            OpenTheDoor();
        else
            CloseDoor();
    }
}

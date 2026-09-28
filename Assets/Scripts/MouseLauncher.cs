using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLauncher : MonoBehaviour
{
    // Update is called once per frame
    public Launcher Launcher;
    void Update()
    {
        // if mouse is clicked
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Launch();
        }
        
        
        // lauch ball
    }

    private void Launch()
    {
        // Figure direction to aim
        Vector2 aimDirection = GetAimDirection();
        
        // launch in that direction
        Launcher.Launch(aimDirection);
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
}

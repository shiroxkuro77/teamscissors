using UnityEngine;

public class Portal : MonoBehaviour
{
    // target portal connected to this portal
    [SerializeField]
    private GameObject linkedPortal;
    private Vector3 targetPosition;
    // prevent unlimited traversal between portals
    private bool isPortalActive = true;

    void ToggleActive()
    {
        isPortalActive = !isPortalActive;
    }

    void OnTriggerEnter(Collider player)
    {
        // makes target portal inactive to prevent teleporting back
        linkedPortal.GetComponent<Portal>().ToggleActive();
        // make current portal inactive
        ToggleActive();

        targetPosition = linkedPortal.transform.position;
        player.transform.position = new Vector3(
            targetPosition.x,
            targetPosition.y,
            player.transform.position.z);
    }

    void OnTriggerExit(Collider player)
    {
        // when player teleports away or exits target portal, reset active state
        ToggleActive();
    }
}

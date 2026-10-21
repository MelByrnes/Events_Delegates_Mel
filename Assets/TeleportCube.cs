using UnityEngine;

public class TeleportCube : MonoBehaviour
{

    private void OnEnable()
    {
        Eventmanager.OnClicked += Teleport;
    }

    private void OnDisable()
    {
        Eventmanager.OnClicked -= Teleport;
    }



    void Teleport() {
        Vector3 pos = transform.position;
        pos.y = Random.Range(.5f, 100f);
        pos.x = Random.Range(.5f, 100f);
        pos.z = Random.Range(.5f, 100f);
        transform.position = pos;
    }



}

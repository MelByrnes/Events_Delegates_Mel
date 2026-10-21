using UnityEngine;

public class TurnColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        Eventmanager.OnClicked += TurnColors;
    }

    private void OnDisable()
    {
        Eventmanager.OnClicked -= TurnColors;
    }

    void TurnColors() {
        Color col = new Color(Random.value,Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }


}

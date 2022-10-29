using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{ 
    public Transform cameraTranform;
    public float parallaxFactor;

    private Vector3 prevCameraPosition;
    private Vector3 deltaCameraPosition; //różnica przesunięcia kamery
    // Start is called before the first frame update
    void Start()
    {
        prevCameraPosition = cameraTranform.position;
    }

    // Update is called once per frame
    void Update()
    {
        deltaCameraPosition = cameraTranform.position - prevCameraPosition;
        Vector3 parallaxPosition = new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactor), transform.position.y, transform.position.x); // do bieżącej pozycji x dodajemy przesunięcie kamery x współczynnik paralaksy
        transform.position = parallaxPosition;
        prevCameraPosition = cameraTranform.position;

    }
}

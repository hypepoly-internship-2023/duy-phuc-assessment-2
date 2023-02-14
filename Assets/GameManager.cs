using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public Camera cam;
    [SerializeField] private Material[] colors;
    [SerializeField] private GameObject cube;

    [HideInInspector]
    //public bool isHover;
    public float zDistanceCamera;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        zDistanceCamera = cam.WorldToScreenPoint(cube.transform.position).z;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100))
        {
            if(hit.collider.gameObject.name == "Cube")
            {
                cube.GetComponent<MeshRenderer>().material = colors[0];
                //isHover = true;
            } else
            {
                cube.GetComponent<MeshRenderer>().material = colors[1];
                //isHover = false;
            } 
        }
    }
}

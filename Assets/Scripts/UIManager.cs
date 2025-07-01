using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank, fuel;
    public Text tankPosition, fuelPositionText;
    private ObjectManager fuelPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tankPosition.text = tank.transform.position + "";
        fuelPosition = fuel.GetComponent<ObjectManager>();
        fuelPositionText.text = fuelPosition.objPosition + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

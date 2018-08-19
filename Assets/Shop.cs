using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandartTurret ()
    {
        Debug.Log("Standard Turret Purchased");
        buildManager.setTurretBuild(buildManager.standartTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
        Debug.Log("Another Turret Purchased");
        buildManager.setTurretBuild(buildManager.anotherTurretPrefab);
    }


}

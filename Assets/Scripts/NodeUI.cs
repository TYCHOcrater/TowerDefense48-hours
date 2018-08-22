﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {
    public GameObject ui;
    public Text upgradeCost;
    public Button upgradeButton;
    private Node target;
    public Text SellAmount;
    public void SetTarget(Node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }   else
        {
            upgradeCost.text = "DONE";
            upgradeButton.interactable = true;
        }

        SellAmount.text = "$" + target.turretBlueprint.GetSellAmount();
             
        ui.SetActive(true);
    }

    public void Hide ()
    {
        ui.SetActive(false);
    }

    public void Upgrade ()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectedNode();
    }

    public void Sell ()
    {
        target.SellTurret();
        BuildManager.instance.DeselectedNode();
    }

}

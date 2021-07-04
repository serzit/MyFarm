using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryBar : MonoBehaviour
{

    private RectTransform rectTransform;

    private bool _isInventoryBarPositionBottom = true;

    public bool IsInvetoryBarPositionBottom { get => _isInventoryBarPositionBottom; set => _isInventoryBarPositionBottom = value; }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        SwitchInventoryBarPosition();
    }

    private void SwitchInventoryBarPosition()
    {
        Vector3 playerViewportPosition = Player.Instance.GetPlayerViewportPosition();

        if (playerViewportPosition.y > 0.3f && IsInvetoryBarPositionBottom == false)
        {
            // transform.position = new Vector3(transform.position.x, 7.5f, 0f); 
            // this was changed to control the recttransform see below
            rectTransform.pivot = new Vector2(0.5f, 0f);
            rectTransform.anchorMin = new Vector2(0.5f, 0f);
            rectTransform.anchorMax = new Vector2(0.5f, 0f);
            rectTransform.anchoredPosition = new Vector2(0f, 2.5f);

            IsInvetoryBarPositionBottom = true;
        }
        else if (playerViewportPosition.y <= 0.3f && IsInvetoryBarPositionBottom == true)
        {
            // transform.position = new Vector3(transform.position.x, mainCamera.pixelHeight - 120f, 0f;
            // this was changed to control the recttransform see below
            rectTransform.pivot = new Vector2(0.5f, 1f);
            rectTransform.anchorMin = new Vector2(0.5f, 1f);
            rectTransform.anchorMax = new Vector2(0.5f, 1f);
            rectTransform.anchoredPosition = new Vector2(0f, -2.5f);

            IsInvetoryBarPositionBottom = false;
        }
    }
}

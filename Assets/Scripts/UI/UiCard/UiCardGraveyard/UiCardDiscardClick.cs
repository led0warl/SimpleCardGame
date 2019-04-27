﻿using Extensions;
using SimpleCardGames.Battle;
using SimpleCardGames.Battle.Controller;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Tools.UI.Card
{
    /// <summary>
    ///     Dicard/Play cards when the object is clicked.
    /// </summary>
    [RequireComponent(typeof(IMouseInput))]
    public class UiCardDiscardClick : MonoBehaviour
    {
        private UiCardUtils Utils { get; set; }
        private IMouseInput Input { get; set; }

        private void Awake()
        {
            Utils = transform.parent.GetComponentInChildren<UiCardUtils>();
            Input = GetComponent<IMouseInput>();
            Input.OnPointerClick += PlayRandom;
        }

        private void PlayRandom(PointerEventData obj)
        {
            var myPlayer = GameController.Instance.GetPlayerController(PlayerSeat.Bottom).Player;
            if (myPlayer.Hand.Size > 0)
            {
                var rndCard = myPlayer.Hand.Units.RandomItem();
                if (rndCard != null)
                    myPlayer.Discard(rndCard);
            }
        }
    }
}
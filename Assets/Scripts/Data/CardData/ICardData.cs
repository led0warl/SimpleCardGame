﻿using SimpleCardGames.Data.Effects;
using UnityEngine;

namespace SimpleCardGames.Data
{
    public interface ICardData
    {
        CardId Id { get; }
        string CardName { get; }
        CardType CardType { get; }
        string CardDescription { get; }
        Sprite Artwork { get; }
        EffectsSet Effects { get; }
    }
}
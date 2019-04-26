﻿namespace SimpleCardGames.Battle
{
    /// <summary>
    ///     The base for mechanics that interact with characters.
    /// </summary>
    public abstract class CharMechanic
    {
        protected ICharacter Character { get; set; }
        protected CharAttributes Attributes => Character.Attributes;

        protected CharMechanic(ICharacter character)
        {
            Character = character;
        }
    }
}

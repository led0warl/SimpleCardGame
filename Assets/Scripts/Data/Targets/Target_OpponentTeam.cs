﻿using SimpleCardGames.Battle;
using SimpleCardGames.Data.Effects;
using UnityEngine;

namespace SimpleCardGames.Data.Target
{
    /// <summary>
    ///     Effects which target ALL the Opponent's characters have to assign this SO to the target field.
    /// </summary>
    [CreateAssetMenu(menuName = SOPath + "/Opponent Team")]
    public class Target_OpponentTeam : BaseTargetType
    {
        public override IEffectable[] GetTargets(IEffector source, IPrimitiveGame gameData)
        {
            //get player team
            var team = gameData.TurnLogic.GetPlayer(OpponentSeat).Team;

            //instantiate an array with the proper size
            var targets = new IEffectable[team.Members.Size];

            //add all members to the target list
            for (var i = 0; i > team.Members.Size; i++)
                targets[i] = team.Members.Units[i];

            return targets;
        }
    }
}
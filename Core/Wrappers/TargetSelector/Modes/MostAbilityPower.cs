﻿// <copyright file="MostAbilityPower.cs" company="LeagueSharp">
//    Copyright (c) 2015 LeagueSharp.
// 
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
// 
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
// 
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see http://www.gnu.org/licenses/
// </copyright>

namespace LeagueSharp.SDK.Modes
{
    using System.Collections.Generic;
    using System.Linq;

    using LeagueSharp.SDK.Core.UI.IMenu;

    /// <summary>
    ///     The most ability power Mode.
    /// </summary>
    public class MostAbilityPower : ITargetSelectorMode
    {
        #region Public Properties

        /// <inheritdoc />
        public string DisplayName => "Most Ability Power";

        /// <inheritdoc />
        public string Name => "most-ability-power";

        #endregion

        #region Public Methods and Operators

        /// <inheritdoc />
        public void AddToMenu(Menu menu)
        {
        }

        /// <inheritdoc />
        public List<Obj_AI_Hero> OrderChampions(List<Obj_AI_Hero> heroes)
        {
            return heroes.OrderBy(x => x.TotalMagicalDamage).ToList();
        }

        #endregion
    }
}
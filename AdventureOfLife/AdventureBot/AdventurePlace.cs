using System;
using System.Collections.Generic;
using System.Text;
using static AdventureOfLife.Enums.AdventureEnums;

namespace AdventureOfLife.AdvenAdventureBot
{
    public class AdventurePlace
    {
        //--- Fields ---
        /// <summary>
        /// Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Place description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Player instructions 
        /// </summary>
        public readonly string Instructions;
        /// <summary>
        /// Fiished or not
        /// </summary>
        public readonly bool Finished;
        /// <summary>
        /// Liste of choices
        /// </summary>
        public readonly Dictionary<AdventureCommandType, IEnumerable<KeyValuePair<AdventureActionType, string>>> Choices;

        //--- Constructors ---
        public AdventurePlace(string id, string description, string instructions, bool finished, Dictionary<AdventureCommandType, IEnumerable<KeyValuePair<AdventureActionType, string>>> choices)
        {
            Id = id;
            Description = description;
            Instructions = instructions;
            Finished = finished;
            Choices = choices;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static AdventureOfLife.Enums.AdventureEnums;

namespace AdventureOfLife.AdventureBot
{
    public class AdventureState
    {

        //--- Fields ---
        public string CurrentPlaceId;
        public AdventureStatus Status = AdventureStatus.New;

        //--- Constructors ---
        public AdventureState(string currentPlaceId)
        {
            Reset(currentPlaceId);
        }

        //--- Methods ---
        public void Reset(string currentPlaceId)
        {
            Status = AdventureStatus.New;
            CurrentPlaceId = currentPlaceId;
        }
    }
}

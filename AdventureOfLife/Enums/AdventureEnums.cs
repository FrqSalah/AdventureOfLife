using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureOfLife.Enums
{
    public class AdventureEnums
    {
        public enum AdventureCommandType
        {
            One = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            OptionOne = 1,
            OptionTwo,
            OptionThree,
            OptionFour,
            OptionFive,
            OptionSix,
            OptionSeven,
            OptionEight,
            OptionNine,
            Yes = 100,
            No,
            Describe = 200,
            Help,
            Hint,
            Restart,
            Quit
        }

        public enum AdventureActionType
        {
            Goto = 1,
            Say,
            Pause,
            Play
        }

        public enum AdventureStatus
        {
            New,
            InProgress,
        }
    }
}

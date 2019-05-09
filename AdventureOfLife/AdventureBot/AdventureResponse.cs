using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureOfLife.AdventureBot
{
    public abstract class AdventureResponse
    {
    }

    public class AdventureResponseSay : AdventureResponse
    {
        //--- Fields ---
        public string Text;

        //--- Constructors ---
        public AdventureResponseSay(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }

    public class AdventureResponseDelay : AdventureResponse
    {

        //--- Fields ---
        public readonly TimeSpan Delay;

        //--- Constructors ---
        public AdventureResponseDelay(TimeSpan delay)
        {
            Delay = delay;
        }
    }

    public class AdventureResponsePlay : AdventureResponse
    {

        //--- Fields ---
        public readonly string Name;

        //--- Constructors ---
        public AdventureResponsePlay(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }

    public class AdventureResponseNotUnderstood : AdventureResponse { }

    public class AdventureResponseBye : AdventureResponse { }

    public class AdventureResponseFinished : AdventureResponse { }

    public class AdventureResponseMultiple : AdventureResponse
    {

        //--- Fields ---
        public readonly IEnumerable<AdventureResponse> Responses;

        //--- Constructors ---
        public AdventureResponseMultiple(IEnumerable<AdventureResponse> responses)
        {
            Responses = responses ?? throw new ArgumentNullException(nameof(responses));
        }
    }
}

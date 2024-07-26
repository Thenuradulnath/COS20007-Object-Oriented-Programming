using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration5
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if ((text.Length != 3) && (text.Length != 5))
            {
                return "I don't know how to look like that";
            }
            else if (text[0] != "look")
            {
                return "Error in look input";
            }
            else if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if ((text.Length == 5) && (text[3] != "in"))
            {
                return "What do you want to look in?";
            }

            String itemId = text[2];
            IhaveInventory container = p;

            if (text.Length == 5)
            {
                container = FetchContainer(p, text[4]);
                if (container == null)
                {
                    return $"I cannot find the {text[4]}";
                }
            }

            return LookAtIn(itemId, container);
        }

        private IhaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IhaveInventory;
        }

        private string LookAtIn(string thingId, IhaveInventory container)
        {
            var item = container.Locate(thingId);
            if (item != null)
            {
                return item.FullDescription;
            }
            else
            {
                return $"I can't find the {thingId}";
            }
        }
    }
}

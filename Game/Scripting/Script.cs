using System.Collections.Generic;

namespace Lost.Game.Scripting 
{

    public class Script 
    {

        private Dictionary<string, List<Action>> actions = new Dictionary<string, List<Action>>();


        public Script()
        {

        }

        public void AddAction(string group, Action action)
        {
            if (!actions.ContainsKey(group))
            {
                actions[group] = new List<Action>();
            }

            if (!actions[group].Contains(action))
            {
                actions[group].Add(action);
            }
        }

        public void ClearActions(string group) 
        {
            if (actions.ContainsKey(group))
            {
                actions[group] = new List<Action>();
            }
        }

        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (actions.ContainsKey(group))
            {
                results.AddRange(actions[group]);
            }

            return results;
        }

        public void RemoveActions(string group, Action action)
        {
            if (actions.ContainsKey(group))
            {
                actions[group].Remove(action);
            }
        }
    }
}


namespace InfoMatch
{
    public class Info
    {
        EventClass onEvent = new EventClass();
        public  void Dangeros()
        {
            onEvent.onEvent("Dangeros moment");
        }

        public  void DangerosCompeted()
        {
            onEvent.onEvent("Dangeros competed");
            
        }
        public  void InfoMatch(string str)
        {

            switch (str)
            {
                case "Dangaros atack":
                case "Angular":
                case "Card":
                    Dangeros();
                    break;
                case "Completed dangaros atack":
                case "Completed angular":
                case "Completed card":
                    DangerosCompeted();
                    break;
            }
        }
        public void Atack()
        {
            var array = new HashSet<string>() { "Dangaros atack", "Dangaros atack", "Dangaros atack", "Completed dangaros atack", "Completed dangaros atack",  "Angular", "Card","Completed angular", "Completed card", };
            foreach (string arr in array)
                InfoMatch(arr);
        }
    }
}

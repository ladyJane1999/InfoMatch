

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
            var array = new List<string>() { "Dangaros atack", "Dangaros atack", "Dangaros atack", "Completed dangaros atack", "Completed angular", "Completed card", "Angular", "Card" };
            for (int i = 0; i < array.Count; i++)
            {
                InfoMatch(array[i]);
            }
        }
    }
}

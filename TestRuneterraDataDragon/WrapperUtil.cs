using LoRDeckCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRuneterraDataDragon
{
    public class WrapperUtil
    {
        public static bool GetDeckFromCode(out List<CardCodeAndCount> deck, string deckCode)
        {
            deck = new List<CardCodeAndCount>();

            try
            {
                deck = LoRDeckEncoder.GetDeckFromCode(deckCode);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static string GetCodeFromDeck(List<CardCodeAndCount> cardCodeAndCounts)
        {
            bool isValid = LoRDeckEncoder.ValidCardCodesAndCounts(cardCodeAndCounts);
            if (!isValid)
            {
                return "";
            }

            return LoRDeckEncoder.GetCodeFromDeck(cardCodeAndCounts);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using LoRDeckCodes;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    /// <summary>
    /// CardCodeAndCountとCardInfoの両方の情報を持つクラス
    /// </summary>
    public class CardDeckDetail
    {
        public CardCodeAndCount cardCodeAndCount { get; set; }
        public CardInfo cardInfo { get; set; }

        public CardDeckDetail(List<CardInfo> allCardInfos, CardCodeAndCount cardCodeAndCount)
        {
            this.cardCodeAndCount = cardCodeAndCount;
            cardInfo = allCardInfos.FirstOrDefault(s => s.cardCode == cardCodeAndCount.CardCode);
            if (cardInfo == null)
            {
                // TODO: エラーログなど
            }
        }
    }
}
using System;

namespace Task2.MES.Domain
{
    public class LotService : ILotService
    {
        // 1. 大腦記憶區：只記住「一個」批次的 ID 和狀態
        private string _id = "";
        private LotStatus _status = LotStatus.Waiting;

        // 2. 存入功能：把 Program 傳進來的資料拆開，存進變數裡
        public void CreateLot(Lot lot)
        {
            _id = lot.Id;
            _status = lot.Status;
        }

        // 3. 取出功能：如果你查的 ID 跟我記住的一樣，我就還你資料
        public Lot GetLotById(string id)
        {
            if (id == _id)
            {
                // 把記住的資訊重新包裝成 Lot 回傳
                return new Lot { Id = _id, Status = _status };
            }
            
            // ID 不對，就回傳 null (查無此批次)
            return null;
        }
    }
}
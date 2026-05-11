using System;

namespace Task2.MES.Domain
{
    public class EquipmentService : IEquipmentService
    {
        // 1. 大腦記憶區：直接用兩個變數，一個記 ID，一個記狀態
        private string _id = "";
        private EquipmentStatus _status = EquipmentStatus.Idle;

        // 2. 存入功能：你給我資料，我就把它存進變數
        public void UpdateStatus(string id, EquipmentStatus newStatus)
        {
            _id = id;
            _status = newStatus;
        }

        // 3. 取出功能：只要 ID 對，我就把剛才記的東西給你
        public Equipment GetEquipmentById(string id)
        {
            if (id == _id)
            {
                return new Equipment { Id = _id, Status = _status };
            }
            return null; // ID 不對就當作沒這回事
        }
    }
}
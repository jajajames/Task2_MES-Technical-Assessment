namespace Task2.MES.Domain;

// 規定產品服務必須有的功能（介面）
public interface ILotService
{
    void CreateLot(Lot lot);
    Lot? GetLotById(string id);
}

// 規定設備服務必須有的功能（介面）
public interface IEquipmentService
{
    void UpdateStatus(string id, EquipmentStatus newStatus);
    Equipment? GetEquipmentById(string id);
}
namespace Task2.MES.Domain;

// 產品批次模型
public class Lot
{
    public string Id { get; set; } = string.Empty;
    public string ProductType { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public LotStatus Status { get; set; } = LotStatus.Waiting;
}

// 設備模型
public class Equipment
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Idle;
}
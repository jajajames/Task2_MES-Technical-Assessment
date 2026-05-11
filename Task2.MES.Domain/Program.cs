using System;
using Task2.MES.Domain; // 確保電腦認識你的 Model 和 Enum

class Program
{
    static void Main()
    {
        // 1. 初始化服務大腦
        var eqService = new EquipmentService();
        var lotService = new LotService();

        Console.WriteLine("======= MES 系統功能測試 =======");

        // --- 第一部分：設備測試 ---
        Console.WriteLine("\n[1. 設備設定]");
        Console.Write("請輸入機台 ID: ");
        string eqId = Console.ReadLine() ?? "";

        Console.Write("請輸入狀態 (0:Idle, 1:Productive, 2:Down, 3:Maintenance): ");
        int eqNum = int.Parse(Console.ReadLine() ?? "0");

        // 設備防呆：檢查輸入的數字是否合法
        if (Enum.IsDefined(typeof(EquipmentStatus), eqNum))
        {
            eqService.UpdateStatus(eqId, (EquipmentStatus)eqNum);
            var eqResult = eqService.GetEquipmentById(eqId);
            Console.WriteLine($">>> 設備查詢成功！ID: {eqResult.Id}, 狀態: {eqResult.Status}");
        }
        else
        {
            Console.WriteLine("❌ 錯誤：設備狀態編號不正確！");
        }

        Console.WriteLine("------------------------------");

        // --- 第二部分：批次測試 ---
        Console.WriteLine("[2. 批次建立]");
        Console.Write("請輸入批次 ID: ");
        string lotId = Console.ReadLine() ?? "";

        Console.Write("請輸入狀態 (0:Waiting, 1:Running, 2:Finished, 3:Scrapped): ");
        int lotNum = int.Parse(Console.ReadLine() ?? "0");

        // 批次防呆：檢查輸入的數字是否合法 (防止出現狀態 4)
        if (Enum.IsDefined(typeof(LotStatus), lotNum))
        {
            lotService.CreateLot(new Lot { Id = lotId, Status = (LotStatus)lotNum });
            var lotResult = lotService.GetLotById(lotId);
            Console.WriteLine($">>> 批次查詢成功！ID: {lotResult.Id}, 狀態: {lotResult.Status}");
        }
        else
        {
            Console.WriteLine("❌ 錯誤：批次狀態編號不正確！");
        }

        Console.WriteLine("\n==============================");
        Console.WriteLine("測試結束，按任意鍵退出...");
        Console.ReadKey();
    }
}
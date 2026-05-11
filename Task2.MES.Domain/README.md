📝 Task 2: MES 設備與批次管理系統 (實作篇)
📌 專案簡介
本階段任務旨在實作 MES (Manufacturing Execution System) 的核心邏輯，包含設備 (Equipment) 與 批次 (Lot) 的狀態管理。透過物件導向的方式，確保資料在存取過程中的正確性與安全性。

🛠️ 核心功能說明
1. 記憶與邏輯層 (Service Layer)
我們實作了 EquipmentService 與 LotService，這兩個服務扮演系統的「大腦」角色：

私有化記憶 (Encapsulation)：使用 private 變數保護資料，防止外部程式直接竄改。

資料驗證 (Validation)：在查詢時透過 if (id == _id) 確保只有 ID 正確時才會回傳資料包，否則回傳 null。

格式標準化：使用 new 關鍵字將原始資料重新打包成 Equipment 或 Lot 物件回傳。

2. 控制與呈現層 (Program Layer)
在主程式 Program.cs 中，我們實作了與使用者的互動邏輯：

防呆機制 (Validation)：利用 Enum.IsDefined 檢查使用者輸入的數字是否在合法的狀態選單 (Enum) 內，避免系統存入不存在的狀態（如：狀態 4）。

自動轉換：將使用者輸入的文字 (String) 轉換為數字 (Int)，再轉型為對應的狀態標籤 (Enum)。

檔案名稱,類別,實作重點
Enums.cs,自訂義選單,定義 EquipmentStatus 與 LotStatus 的合法清單。
Equipment.cs,資料模型,規定設備必須具備 Id 與 Status 兩個零件。
IEquipmentService.cs,介面 (合約),規範服務必須具備 UpdateStatus 與 GetEquipmentById 功能。
EquipmentService.cs,具體實作,撰寫資料儲存、比對與打包的詳細邏輯。
Program.cs,執行點,整合所有服務，處理使用者輸入與防呆顯示。


----執行----
開啟終端機 (Terminal)。

進入專案目錄。

輸入指令執行：

Bash
dotnet run
依照畫面提示輸入機台/批次 ID 與狀態數字 (0-3)。

觀察系統回傳的查詢結果或錯誤提示。
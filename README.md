# 1151VR-HW2-414262349-陳嘉恩

## 專案
Unity 6000.6.2f1，Universal 2D。
開啟 Assets/Scenes/Homework.unity，按 Play 開始自動移動。
角色往前走、跳到兩個高台，再下跳到終點。重播時停止 Play 後重新按 Play。

## 程式說明
角色程式是 Assets/Scripts/Journey.cs，掛在 Character 物件上。
1. Vector3[] points = new Vector3[8] 建立有八個座標的陣列。
2. Start 裡逐一設定 points[0] 到 points[7]，z 座標都設成 0，作為 2D 路線。
3. number 是目前目標的陣列索引，從 1 開始，因為角色已在 points[0]。
4. Update 每影格呼叫 Vector3.MoveTowards，讓角色逐漸靠近 points[number]。
5. speed 是每秒移動速度，Time.deltaTime 是上一影格經過的秒數，兩者相乘得到本影格移動距離。
6. 到達目前目標後，number 加 1，開始移向下一個座標。
7. number 等於 points.Length 時，所有點都走完，Console 顯示「到達終點」，停止移動。

上跳與下跳是依序經過高點、低點的路線動畫，採用直線分段移動。

## 場景製作與調整
人物圖片位於 Assets/Art/Character.png。
Homework 場景、人物圖片與平台先前由輔助工具建立；目前角色執行只使用 Journey.cs。
平台的位置和大小可在 Inspector 的 Transform 調整。
背景顏色可選取 Main Camera，在 Inspector 的 Background 調整。

## 課堂參考
CH03 C# 程式腳本的基礎_1151FJU：變數、if、陣列、Vector。
Vector3.MoveTowards 與 Time.deltaTime 是此作業額外使用的 Unity 功能，上方已說明用途。

## 繳交資料

### 專案截圖
待補上文件中的專案截圖。

### GitHub 連結
[1151VR-HW2-414262349-陳嘉恩](https://github.com/bryan154/1151VR-HW2-414262349--)

### YouTube 連結
[專案執行影片](https://youtu.be/lO7e8qMY4R8)

### 共享狀態
已向老師的 GitHub 帳號 `cchu-fju` 送出邀請，等待對方接受。

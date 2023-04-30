using System;

class MainClass {
  public static void Main (string[] args) {
    // รับค่าจำนวนโหนดที่ไม่มีมีทิศทาง
    int n = int.Parse(Console.ReadLine());

    // สร้างตัวแปรเก็บจำนวนสัญลักษณ์ที่ใช้
    int count = 0;

    // สร้างกราฟ
    int[,] graph = new int[n, n];

    // รับค่าลำดับโหนดต้นทางและปลายทาง
    while (true) {
      int from = int.Parse(Console.ReadLine());
      if (from < 0 || from >= n) break;

      int to = int.Parse(Console.ReadLine());
      if (to < 0 || to >= n) break;

      // กำหนดสัญลักษณ์ให้กับเส้นเชื่อมโหนด
      char symbol = (char)('A' + count );
      count++;
      graph[from, to] = symbol;
    }

    // แสดงผลลัพธ์
    Console.WriteLine("result : " + count / 2);
  }
}

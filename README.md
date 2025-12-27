# NexaScanner

NexaScanner, Windows sistemler için geliştirilmiş basit bir açık kaynak hile tarama programıdır.

Bu program bir anticheat değildir. Sadece bilgisayardaki dosya isimlerini tarayarak bilinen hile clientlerini tespit etmeye çalışır.

## Özellikler
- EXE / DLL / JAR dosyalarını tarar
- Bilinen Minecraft hile clientlerini tespit eder
- Hile bulunduğu anda taramayı durdurur
- Tarama yapılacak disk seçilebilir
- Yüzdelik ilerleme çubuğu
- Kernel driver kullanmaz
- Arka planda servis kurmaz
- Veri toplamaz

## Nasıl Çalışır
Seçilen diskteki dosya isimleri taranır.
Dosya adları, önceden belirlenmiş anahtar kelimeler ile karşılaştırılır.
Eşleşme bulunursa tarama durdurulur ve sonuç ekranda gösterilir.

Yanlış pozitif (false positive) ihtimali vardır.

## Gereksinimler
- Windows 10 / Windows 11
- .NET 8 veya .NET 10
- Visual Studio 2022 / 2026

## Uyarı
Bu program kesin olarak hile tespiti yapmaz.
Sadece yardımcı bir tarama aracıdır.
Programın yanlış kullanımından geliştirici sorumlu değildir.

## Lisans
MIT Lisansı

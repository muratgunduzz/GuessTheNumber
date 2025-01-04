# Sayı Tahmin Oyunu 🎯

Bu uygulama, eğlenceli ve basit bir sayı tahmin oyunudur. Oyunda, bilgisayar tarafından 1 ile 100 arasında rastgele bir sayı seçilir ve kullanıcının bu sayıyı tahmin etmesi beklenir. Kullanıcının **5 deneme hakkı** vardır ve her tahmin sonrası çeşitli ipuçları verilir.

---

## 🚀 Özellikler

### 🎮 **Başlangıç Seçeneği**
- Oyuna başlamak için `"y"` veya `"n"` seçeneği sunulur.
- Kullanıcı `"n"` seçse bile, oyun zorunlu olarak başlatılır. Bu durum esprili bir mesajla belirtilir:  
  *"Actually, you have no choice :) Let's start the game!"*

---

### 🔍 **İpucu Sistemi**
- **Doğru sayı ile kullanıcının tahmini arasındaki yakınlık belirtilir.** 
- Doğru sayı, kullanıcının tahmininin **%80 ile %120** aralığında olduğu ifade edilerek tahmin kolaylaştırılır.
- Tahminin uzaklık derecesi şu şekilde sınıflandırılır:
  - **Çok Yakın**: Tahmin ile sayı arasındaki fark **5 veya daha az**.
  - **Yakın**: Fark **15 veya daha az**.
  - **Biraz Uzak**: Fark **30 veya daha az**.
  - **Çok Uzak**: Fark **30'dan fazla**.

---

### 📝 **Önceki Tahminler**
- Kullanıcı, oyunda yaptığı tüm tahminleri görebilir. Böylece bir önceki tahminlerini hatırlayarak daha iyi strateji geliştirebilir.

---

### 🎨 **Renkli Konsol Çıktıları**
- **Başarı mesajları**: Kullanıcı doğru tahmin yaptığında yeşil renk ile gösterilir.
- **Hata mesajları**: Kullanıcının yanlış tahminleri ve kalan deneme sayısı kırmızı renk ile belirtilir.
- Bu görsellik, oyunun etkileşimini artırır.

---

## 🛠️ Kullanım

1. Programı çalıştırın.
2. 1 ile 100 arasında bir sayı tahmin edin.
3. İpuçlarını takip ederek doğru sayıyı bulmaya çalışın.
4. 5 tahmin hakkınız dolmadan doğru sayıyı tahmin ederseniz, oyunu kazanırsınız.

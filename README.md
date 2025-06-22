# 🌍 Arttırılmış Gerçeklik Projesi – Dünya Kaşifi

## 📌 Proje Açıklaması

**Dünya Kaşifi**, artırılmış gerçeklik (AR) tabanlı bir mobil uygulamadır. Bu uygulama sayesinde kullanıcılar, gerçek dünyadaki yapıları cihaz kamerasıyla tarayarak onların 3D modellerini görebilir ve detaylı bilgi alabilirler.

Uygulama açıldığında kullanıcıyı bir **ana ekran** karşılar. Kullanıcı “Başlat” butonuna bastığında cihaz kamerası aktif hale gelir. Kamera, **Eyfel Kulesi**’ni tanıdığında bir **3D model** görünür. Kullanıcı bu modele dokunduğunda ekrana **bilgilendirme paneli** gelir.

- 🎯 **Amaç:** Kültürel yapıları artırılmış gerçeklik ile tanıtmak  
- 👥 **Hedef Kitle:** Öğrenciler, gezginler ve kültürel bilgiye ilgi duyan bireyler  
- 🛠️ **Kullanılan Teknolojiler:**
  - Unity
  - Vuforia Engine (AR SDK)
  - C#
  - Android Build Tools

---

## 🚀 Kurulum Rehberi

1. Unity Hub üzerinden **Unity 2021.x veya 2022.x** sürümü kurulu olmalıdır.
2. **Vuforia Engine** eklentisi Unity üzerinden projeye dahil edilmelidir.
3. Unity projesini açmak için GitHub deposunu klonlayın:
   ```bash
   git clone https://github.com/Osman911P/DunyaKasifi.git
4. Unity içinde açıldıktan sonra Scenes klasöründeki MainMenu.unity sahnesi ile başlayabilirsiniz.
5. Mobil cihazda test etmek için:
- Android Build Support kurulmalı
- Cihazda kamera izinleri verilmelidir

▶️ Kullanım Talimatları
1. Uygulama açıldığında ana menü ekranı gelir.
2. “Başlat” butonuna tıklanır.
3. Uygulama, cihaz kamerasını açar.
4. Eyfel Kulesi görseli cihaza gösterilir.
5. Ekranda 3D Eyfel Kulesi modeli belirir.
6. Modele tıklandığında bilgilendirme paneli (canvas UI) ekranda gösterilir

🧠 AR Özellikleri
1. Görüntü Tanıma: Vuforia kullanılarak Eyfel Kulesi resmi tanınır.
2. 3D Modelleme: Eyfel Kulesi’nin 3D modeli tanıma sonrasında sahneye yerleştirilir.
3. Etkin Dokunma: Modele dokunulduğunda Unity UI canvas paneli açılır.
4. Donanım Gereksinimi: Android kamera donanımı gereklidir.

## 📅 Haftalık Gelişim Süreci

### 1. Hafta
- Trello panosu oluşturuldu ve proje yönetimi için kartlar eklendi.  
🔗 https://trello.com/b/uhaFgmba/ar-dunya-kasifi  
- GitHub üzerinde proje için bir depo (repository) oluşturuldu.  
🔗 https://github.com/Osman911P/DunyaKasifi  

### 2. Hafta
- SWOT Analizi gerçekleştirildi.  
📄 `Swot.docx`  
- Gereksinim Analizi yapıldı.  
📄 `gereksinim_analizi.docx`

### 3. Hafta
- Tasarım Analizi yapıldı.  
📄 `Tasarim Analizi.docx`  
- State Diagram ve Sistem Yapısı gibi temel diyagramlar hazırlandı.

### 4. Hafta
- Tüm UML diyagramları (State Diagram, Activity Diagram, Use Case, vb.) tamamlandı.
- Hepsi Trello panosunda güncellendi.  
🔗 https://trello.com/b/uhaFgmba/ar-dunya-kasifi

### 5. Hafta
- Unity kurulumu sağlandı.
- Gerekli assetler (3D model, Vuforia, UI elementleri vb.) toplandı.

### 6. Hafta
- Uygulamanın kodlama sürecine başlandı.
- Unity sahnesi oluşturuldu, temel yapı kuruldu.

### 7. Hafta
- Uygulama üzerinde ilk testler yapıldı.
- Vuforia tanıma sistemi ve kamera erişimi test edildi.

---

### 8. Hafta
- Ana giriş ekranı tasarlandı ve uygulamaya entegre edildi.
- “Dünya Kaşifi” başlığı ve “Başlat” butonu eklendi.
- “Başlat” butonuna tıklandığında Unity sahnesine geçiş sağlandı.

### 9. Hafta
- Vuforia ile Eyfel Kulesi tanıma özelliği tamamlandı.
- Eyfel Kulesi’ne karşılık gelen 3D model uygulamaya entegre edildi ve test edildi.
- Model başarıyla görünüyor hale geldi.

### 10. Hafta
- 3D modele dokunma özelliği geliştirildi.
- Tıklama ile birlikte bilgi ekranı (canvas UI) gösterimi sağlandı.
- Bilgi ekranı düzenlendi ve kullanıcıya yapıya dair bilgi gösterimi tamamlandı.

---
Uygulama içi görseller : 
![resim 1](https://github.com/user-attachments/assets/d3dcddd5-a762-41ba-b09f-b11eee857379)

![resim 2](https://github.com/user-attachments/assets/3ab935a3-ba1d-42f1-8f87-9ea62368d0c3)

---
Uygulama Tanıtım Videosu : 

https://youtube.com/shorts/T4ujbI28cko?feature=share

📦 APK Dosyası (İndirilebilir Sürüm)
Uygulamanın Android .apk dosyasını aşağıdaki bağlantıdan indirebilirsiniz:

🔗 Dünya Kaşifi - [APK İndir (Google Drive)](https://drive.google.com/file/d/1plmvJl23t1HnFuP2RA3TgHhFKK5rb0PQ/view?usp=sharing)



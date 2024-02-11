# Otopark_Otomasyonu

## Proje Tanıtımı 

*Bu projede **.Net** kullanarak otopark otomasyonu oluşturdum. CRUD operasyonları için ado.net kullanıldım.*

# Database Yedeği #
Databse kısmına aşşağıdan ulaşıp kendinize yükleyebilirsiniz. https://github.com/emreilhangithub/Otopark_Otomasyonu/tree/master/database

# Proje İçeriği #

### Anasayfa
Otopark sorumlusu sisteme giriş yaptığı zaman onu işlemler yapabileceği bir panel karşılar.
![Anasayfa](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/Anasayfa.png)

### Arac Otopark Yerleri
Otopark sorumlusu hangi park yerlerinin boş yada dolu olduğunu bu ekrandan anlar. 

Eğer dolu ise dolu olan yerin örnek P-1 alanı için textbox kırmızı yapar ve için plaka numarasını doldurur.


![AracOtoparkYerleri](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkYerleri.png)

### Arac Otopark Kaydi
1)Otopark sorumlusu park yerine giriş yapmış aracı kayıt etmek için bu ekranı kullanır.


![AracOtoparkKaydi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkKaydi.png)


2)Marka kısmında daha önce kayıtlı markaları getiriyor.
![MarkaListesi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/MarkaListesi.png)

Eğer marka ekleme istiyorsanız + butonuna basıp sizi karşılayacak ekrandan ekle butonuna basabilirsiniz.
![MarkaEkle](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/MarkaEkle.png)

3)Seri kısmında daha önce kayıtlı markaya ait serileri getiriyor.
![SeriListesi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/SeriListesi.png)

Eğer seri ekleme istiyorsanız + butonuna basıp sizi karşılayacak ekrandan markasını ekleyeceğiniz seri adını yazarak ekle butonuna basabilirsiniz.


![SeriEkle](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/SeriEkle.png)

4)Kişi bilgileri ve araç bilgilerini doldurduktan sonra kayıt et butonuna basılır.

Aşşağıdaki ekranda görüldüğü üzere artık kayıt işleminiz tamamlanmıştır. Araç otomapark yerleri ekranından bakabilirsiniz.
![AracOtoparkKaydiYapildi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkKaydiYapildi.png)

### Çıkış Yapmış Araçlar
Bu ekranda otoparkdan çıkış yapmak isteyen araca çıkış yaptırılır.


1)Öncelikle burada plaka seçilir ve seçilen plakaya göre aracın hangi park alanından çıkış yapacağı bulunur.
![AracOtoparkCikisPlakaBilgileri](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkCikisPlakaBilgileri.png)

2)Park Yeri seçilmeledir park yeri seçilince o park yerine giriş yapan kişi ve aracın bilgileri aşşağıda listelenilir.
![AracOtoparkCikis](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkCikis.png)

3)Park yeri seçilince aracın geliş tarihi,çıkacağı tarih(anlık değişiyor),süre vede toplam ödeyeceği tutar yazmaktadır.
![AracOtoparkCikisUcretBilgi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkCikisUcretBilgi.png)

4)Otopark sorumlusu müşteriden ödeyeceği tutarı tahsil ettikten sonra Araç Çıkış butonuna basarak çıkışı gerçekleştirir.

Artık P2 yani park2 alanı boştur.

![AracOtoparkCikisYapildi](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/AracOtoparkCikisYapildi.png)


### Çıkış Yapmış Araçlar
Bu ekranda daha önce otoparkdan çıkış yapmış araçları listelemektedir bu ekran daha önceki kayıtlara erişmek için yapıldı.
![CikisYapmisAraclar](https://github.com/emreilhangithub/Otopark_Otomasyonu/blob/master/images/CikisYapmisAraclar.png)

```.NET``` ```C#``` ```MSSQL```  ```WindowsForm``` ```Software``` ```Computer``` ```Programmer```
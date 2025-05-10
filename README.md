Metodlar Konsol Uygulaması

Bu proje, C# dilinde çeşitli metot örneklerini barındıran basit bir konsol uygulamasıdır. Metotların nasıl tanımlandığını ve çağrıldığını öğrenmek için kullanılabilir.

Özellikler

sarkiSözleri(): Sabit şarkı sözlerini konsola yazar.

rastgeleTamsayi(): 1 ile 100 arasında rastgele bir tamsayı oluşturur ve ekrana yazdırır.

carpimYapanMetod(int a, int b): Parametre olarak aldığı iki sayının çarpımını hesaplayıp döner.

SelamVer(string ad, string soyAd): Kullanıcının girdiği ad ve soyadı kullanarak selamlama mesajı gösterir.

Gereksinimler

.NET SDK (6.0 veya üzeri önerilir)

C# 10 veya üzeri

Kurulum ve Çalıştırma

Projeyi klonlayın veya indirin.

Proje klasörüne terminal/komut satırından gidin.

Aşağıdaki komutları çalıştırarak bağımlılıkları yükleyin ve uygulamayı başlatın:

dotnet restore
dotnet run

Kullanım Akışı

Uygulama çalıştığında önce sarkiSözleri() ve rastgeleTamsayi() metotları çalışır.

Ardından konsoldan iki tamsayı girmeniz istenir ve carpimYapanMetod ile girilen sayıların çarpımı hesaplanır.

Son olarak ad ve soyad bilgisi istenir ve SelamVer metodu çağrılarak selamlama mesajı görüntülenir.

Metot Detayları

Metot Adı

Parametreler

Dönüş Tipi

Açıklama

sarkiSözleri()

Yok

void

Konsola sabit şarkı sözlerini yazar.

rastgeleTamsayi()

Yok

void

1-100 arası rastgele tamsayı oluşturur.

carpimYapanMetod(a,b)

int a, int b

int

İki sayının çarpımını hesaplayıp döner.

SelamVer(ad, soyAd)

string ad, string soyAd

void

Girilen ad ve soyadı kullanarak selamlar.

Örnek Çıktı

--------------------------
Kasette Simge'den Aşkin olayim çaliyor.
--------------------------
Aşkiiin olayiiim
--------------------------
Rastgele Bir Tam Sayi Oluşturuyoruz 1-100 arasinda
--------------------------
Rastgele tamsayi (1-100): 42
--------------------------
Birinci sayiyi girin: 5
İkinci sayiyi girin: 7
5 × 7 = 35
Bir ad Giriniz: Bilal
Bir Soyad Giriniz: Hantik
Hoş Geldiniz Bilal Hantik


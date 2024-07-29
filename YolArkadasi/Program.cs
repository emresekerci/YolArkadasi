//Kullanıcıdan gitmek istediği lokasyonu alıyoruz ve küçük/büyük harf duyarlılığını kaldırıyoruz.
//Doğru seçim yapılana kadar kullanıcıya tekrar sormak için bir switch yapısı kullanıyoruz.
while (true)
{
    Console.WriteLine("Gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");
    string lokasyon = Console.ReadLine().ToLower();

    int paketFiyati = 0;
    switch (lokasyon)
    {
        case "bodrum":
            paketFiyati = 4000;
            break;
        case "marmaris":
            paketFiyati = 3000;
            break;
        case "çeşme":
            paketFiyati = 5000;
            break;
        default:
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen Bodrum, Marmaris veya Çeşme seçeneklerinden birini giriniz.");
            continue;
    }
    //Kullanıcıdan geçerli bir kişi sayısı girmesini istiyoruz ve doğru bir sayı girene kadar döngü devam ediyor.
    Console.WriteLine("Kaç kişi için tatil planlıyorsunuz?");
    int kisiSayisi;
    while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }

    Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon}");
    Console.WriteLine($"Kişi sayısı: {kisiSayisi}");

    //Kullanıcıya iki ulaşım seçeneği sunuyoruz ve geçerli bir seçim yapana kadar soruyu tekrar ediyoruz.
    Console.WriteLine("Tatiline ne şekilde gitmek istersiniz? 1 - Kara yolu, 2 - Hava yolu");
    int ulasimSecimi;
    while (!int.TryParse(Console.ReadLine(), out ulasimSecimi) || (ulasimSecimi != 1 && ulasimSecimi != 2))
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 seçeneklerinden birini giriniz.");
    }
    //Kullanıcıya iki ulaşım seçeneği sunuyoruz ve geçerli bir seçim yapana kadar soruyu tekrar ediyoruz.
    int ulasimFiyati = (ulasimSecimi == 1) ? 1500 : 4000;
    int toplamFiyat = (paketFiyati + ulasimFiyati) * kisiSayisi;

    Console.WriteLine($"Toplam tatil maliyetiniz: {toplamFiyat} TL");

    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (E/H)");
    string devam = Console.ReadLine().ToLower();
    if (devam != "e")
    {
        Console.WriteLine("İyi günler!");
        break;
    }
}
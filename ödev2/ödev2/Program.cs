// See https://aka.ms/new-console-template for more information
using ödev2.sınıflar;

// Array : Aynı veri tipindeki değişkenleri sıralamaya yarar.Verilerin hızlı bir şekilde işlenmesi ve saklanması için kullanılır.
  
    {
      Hareketsekli bmw = new BMW();
        Console.WriteLine("Bmw'nin hareket kabiliyetleri:");
        bmw.Hizligit();
        bmw.Havadagit();
        bmw.Denizgit();
        Console.WriteLine();  
    }
{
    Hareketsekli mercedes = new Mercedes();
    Console.WriteLine("Mercedes'in hareket kabiliyetleri:");
    mercedes.Hizligit();
    mercedes.Havadagit();
    mercedes.Denizgit();
    Console.WriteLine();
}

{
    Hareketsekli porsche = new Porsche();
    Console.WriteLine("Porsche'nin hareket kabiliyetleri:");
    porsche.Hizligit();
    porsche.Havadagit();
    porsche.Denizgit();
    Console.WriteLine();
}




Genelmudur gm= new Genelmudur();
Mudur md= new Mudur();
Programci pr = new Programci();
Stajyer st= new Stajyer();

double totalMaas = 0.0;

totalMaas += gm.maasmiktari();
totalMaas += md.maasmiktari();
totalMaas += pr.maasmiktari();
totalMaas += st.maasmiktari();
Console.WriteLine("Toplam: " + totalMaas +" Birim maaş alıyorlar");


{
    Bmw2 bmw2 = new Bmw2();
    Mercedes2 mercedes2 = new Mercedes2();
    Porsche2 porsche2 = new Porsche2();

    double toplamyakıttuketimi = 0.0;

    toplamyakıttuketimi += bmw2.yakit();
    toplamyakıttuketimi += mercedes2.yakit();
    toplamyakıttuketimi += porsche2.yakit();
    Console.WriteLine("Toplam: " + toplamyakıttuketimi + "L Tüm Araçlar 1 saatte toplam bu kadar yakıt tüketti");
}
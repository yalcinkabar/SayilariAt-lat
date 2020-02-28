# SayilariAt-lat
*Bu SayılarıAt-lat adlı oyun uygulaması Software Construction (Yazılım Yapımı) dersi için temel form araçları kulanılarak geliştirilmiştir.*

#### AÇIKLAMA ####
Açılışta kullanıcıdan oyunun boyutu istenmektedir, ona göre de kutucuklar oluşturulmaktadır. Kutucuğa tıklandığında tıklanan kutucuğun rengi mor olmakta ve oynanabilecek hamleler (L şeklindeki koordinatlara sahip olan ve seçilen oyun boyutunun sınırları içerisinde yer alan kutucuklar) yeşil renkte olmaktadır. (Sadece yeşil renkteki kutucuklar tıklanabilir olup diğer kutucuklar tıklanamaz halini alır.) Yeşil renkteki kutucukların birine tıklandığında önceki tıklanan (mor renkteki) kutucuğun rengi solmaktadır. Oyun böyle devam etmektedir. Eğer tüm kutucuklar tıklanmışsa oyun kazanılmıştır ve son tıklanan kutucuğun rengi turuncu olmaktadır. Eğer ki oynanabilecek hamle kalmamışsa da oyun kaybedilmiştir ve son tıklanan kutucuğun rengi kırmızı olmaktadır. Oyun kazanılmış ya da kaybedilmiş olsun kullanıcıya gerekli yönlendirmeler yapılarak ya oyundan çıkış yapılır ya da yeni oyun oluşturulur.

Kullanılan Sınıflar:
<ol type="i">
<li>Kontrol.cs</li> 
<li>Kutucuk.cs</li>
<li>MsgBox.cs* // messagebox’ları formun ortasına hizalamak için oluşturulan sınıf</li>
<li>Oyun.cs</li>
<li>OyunBoyutu.cs</li>
<li>Win32.cs* // MsgBox.cs için gerekli metotları barındıran sınıf</li>
</ol>

(*) http://www.codeproject.com/KB/dialog/MessageBoxCenterOnParent.aspx adresinden faydalanılmıştır.

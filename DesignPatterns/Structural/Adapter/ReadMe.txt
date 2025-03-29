Adapter (Adaptör) Pattern, bir sınıfın arayüzünü başka bir sınıfın arayüzüne çeviren bir patterndir. Uyumsuz arayüzleri sebebiyle çalışamayacak sınıfların bir arada çalışmasını sağlar.

//Problem1
Uyumusz arayüz problemini aşmak için uyum problemi olan sınıfta değişklik yapmak OCP'ye aykırıdır.  

//Problem2
Uyumsuzluğu gidermek için inheritance kullanılarak bir subclass yaratılıp uyum sağlanabilir. Ancak her ihtiyaç olduğunda bir subclass yaratmak, aşırı derecede subclass üretimine sebebiyet verebilir.
Uyumsuzluk sorununu miras ile genişletmeye çalışmadaki en temel sıkıntı, adaptörü ana class içine gömmektir. Bu durumda da SRP'ye aykırı bir durum ortaya çıkar. Halbuki adaptörlük apayrı bir sorumluluk ve roldür; ana sınıfın içine gömülmemelidir. 
Bu şekilde bir işlem yapılırsa her sınıfın içine adaptör gömmek gerekir ve her ayrı ihtiyaç için bir sınıfın içinde birden çok adaptör gömmek gerekir. 
Bir başka sıkıntı da var olan sınıfın sealed olması yani kalıtım verememe durumudur. Bu durumda kalıtımla adaptör eklenemez.

********** Çözüm **********
//(PowerAdapter1)
Olması gereken, uyum problemini uyumu sağlayacak bir sınıfta çözmektir. Bu sınıf adaptör sınıfıdır. Bu sınıf, var olan istemciyi,  uyumsuz arayüze sahip olan sınıfla çalışabilir hale getirmektedir.
Adapter sınıfı, uyumsuz sınıf ile istemcinin kendisiyle çalışmasını bildiği arayüz arasına girer ve uyumsuz sınıfı, o arayüzle uyumlu hale getirir.
//(PowerADapter2)
Bazen adaptörler, uyumsuz nesneyi uyumlu hale getirmekten daha çok iş yapabilirler yani uyumsuz nesneye erişmeden önce ya da dönüşte bazı hizmetler sağlayabilirler. Bu yaklaşımda adaptörün sadece uyum ile yakın ilişki içinde olan ek hizmetleri yaparak odağını düşürmemesi önemlidir. Eğer ki ek hizmetler adaptörün odağını düşürecek ise bunları ayrı yapılara kaydırmak daha iyidir.

//TwoWayAdapter
İki taraflı çalışabilen adaptördür, ilgili sınıflara ait arayüzleri implement edip çift taraflı bir kullanım sağlar.
iki yönlü adaptörde birden çok uyumsuz arayüz birbirleriyle uyumlu hale getireilebilir fakat arayüz sayısı arttıkça sınıf içindeki karışıklık artacaktır ve kullanım zorlaşacaktır.
Bu nedenlerden dolayı nesnenin kendisine uydurulacağı birden fazla arayüz var ise, her arayüz için ayrı bir adaptör yapılması önerilir.

//JavaSwing Örneği

Bu örnekte adaptör örneği farklı bir amaçta kullanılmıştır, örnekte mouse eventlerinden bazıları yakalanmak isteniyor. Mouse eventleri için toplamda 3 ayrı interface tanımlanmış ve toplamda 8 metot bulunmaktadır. Bir arayüzde bulunan herhangi bir metot kullanılmak istendiğinde diğer metotları da implement edilmesi gerekecektir ve bu ISP'ye aykırı bir durumdur. Bu durumdan kurtulmak için bir abstract adaptör tanımlanmış ve 3 arayüzü implement etmiştir, böylelikle bu adaptörü implement eden herhangi bir sınıf istediği metotları override ederek kullanabilecektir.


********* Sonuç *********
Adaptor kalıbı, işimize yarayan ama istediğimiz (çalışmasını bildiğimiz) arayüze sahip olmayan nesneyi kullanılabilir yapar. Bunu da istediğimiz nesnenin arayüzüne dokunmadan,onu bir adaptör yardımıyla sarmalayarak gerçekleştirir.
Adaptor'ün ne kadar iş yaptığı, uyumsuzluğun miktarıyla ilgilidir.
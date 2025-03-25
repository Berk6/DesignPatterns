Tüy Siklet olarak da geçer.

Bazen çözümlerimizde ufak-tefen olan çok sayıda nesne kullanmak durumunda kalırız. Örneğin bir kitabın modellenmesinde kullanılabilecek sayfa, paragraf, satır, kelime ve harf nesneleri bu cinstendir. Bir kitap için 500 sayfa kullanılacağı zaman gerçekten 500 nesne mi oluşturmalıyım? sorusuna cevap verecektir. 
Eğer ki her defasında tek bir sayfa kullanılıyorsa, tekrar tekrar nesne üretmek yerine reuse yani tekrar kullanım şekli benimsenebilir.

Bu türden uygulamalarda nesnelerin sayısı, dikkatsiz kullanım durumunda aşırı bir şekilde artabilir. Çok fazla nesne kullanımı ise bellek ve CPU problemleri yol açabilir. Nesne oluşturmak ve sonradan GC ile toplamak masraflıdır. Bu durumda nesnelerin tekrar kullanımı önem kazanır. 

Flyweight nesne farklı bağlamlar tarafından ortaklaşa kullanılır ama nesne her bağlamda bağımsız olarak davranır. İçinde bulunduğu bağlam ile ilgili bir bilgiyi edinebilir ve buna göre davranışı değişebilir.

Bu noktada sinek siklet nesnenin durumu ile ilgili şu ayrımı yapabilir.
	* İçsel ya da asıl durum (intrinsic state) 
	* Dışsal ya da geçici durum (extrinsic state)

içsel durum temsil ettiği asıl durum iken dışsal durum içinde bulunduğu bağlam tarafından belirlenen durumdur.
Örneğin bir oyun yazılımında bir askerin giysisi(contexte göre değişmiyorsa) içsel durum iken askerin koordinatları dışsal durumdur.

Flyweight sınıfının kaç nesnesinin aynı anda kullanılacağı, yaratılacak nesne sayısını belirleyen faktördür.

* Flyweight (Sinek siklet) nesneler bir Factory Method yardımıyla oluşturulur.
* Oluşturulan Flyweight nesneler bir nesne havuzuna konulabilir.
* Oluşturulan sınırlı sayıda nesnenin içsel durumu belirlenir.
* Sonrasında oluşturulan nesneler farklı bağlamlarda tekrar kullanılır.
* Dışsal durum ise nesne kullanıldığı bağlama göre belirlenir.
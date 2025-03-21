Abstract Factory Kalıbı birbirleriyle ilgili ya da bağımlı nesne ailelerini, nesnelerin somut sınıflarını belirtmeden yaratmak için bir arayüz sağlamayı amaçlar.

Abstract factory bir sınıftır, Factory Method ise bir metottur.
Factor Method tek bir nesnenin, Abstract Factory birden fazla nesnenin yaratılmasını soyutlar.
Abstract Factory birden çok Factory Method'a sahiptir.

Factory method bir sınıf içerisinde oluşturulur fakat tek bir metoda sahiptir, Abstract Factory ise birden çok metodu bir arada bulundurur.

//Solution1
Soyutlamanın tek bir arayüz üzerinden yapıldığı ve nesne oluşturmak için tek bir metot kullanılan durumlarda farklı parametrelere ihtiyaç duyulacaktır.

//Solution2
Bir bütünü oluşturan parçalara ait Factory Metotları bir araya getirilerek Abstract Factory oluşturulur. Her biri ayrı ayrı oluşturulan ve farklı sınıflara konan bu parçaların(Factory Methodların) bir sınıfta toplanmaları makuldür ve toplantıkları sınıfın kohezyonunu düşürmezler.

//Solution3
Birden çok nesne ailesi varsa her aile için farklı bir Abstract Factory oluşturulur.

Birlikte kullanılacak nesne ailesinin, birden fazla platform için yaratılmaları söz konusu ise Abstract Factory arayüzünün her ortam/platform için farklı bir gerçekleştirmesi de olabilir. Yani her platform için ilgili sınıflara ait alt sınıflar oluşturulur, soyutlamada da alt soyutlamalar oluşturulur.

//Solution 4
Nesne ailesi üyelerinin her zaman ortak ataya sahip olmaları gerekmez. Örneğin Course,Professor,ClassRoom,Time nesnelerini kullanan Üniversite sistemindeki "Ders Al" sürecinde (use case) bu dört nesne Abstract Factory tarafından hep birlikte oluşturulabilir ama ortak ataları yoktur.

//Solution 4_1
Bu çözümdeki en temel kısıt her ortam/platform için hep aynı grupların üretiliyor olmasıdır. 
Eğer farklı ortamlar için farklı türde nesneler üretiliyorsa ortak bir Abstract Factory atasından bahsetmek mümkün değildir.
Bu durumda farklı Abstract Facttory arayüzleri ile onları gerçekleştiren sınıflardan bahsedilir.

Benzer durum farklı ortam/platformdaki nesnelerin farklı parametrelerle yaratılması durumunda da geçerlidir.

Sonuç olarak

Abstract Factory nesne aileleri ve onları üreten nesnelerle ilgili sistematik bir isimlendirme sağlar.
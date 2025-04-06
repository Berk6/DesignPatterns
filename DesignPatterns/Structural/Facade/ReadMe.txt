Facade ve Face latincede aynı kökten gelmektedir.
Fransızca'da "Façade" binaların ön yüzü, ön cephesi anlamına gelir.

Facade bir alt sistemin sağladığı hizmetleri tek ve basit bir arayüz üzerinden sunmasının yoludur.

Örnek

Bir bilgisayara ait bölümler sınıf halinde verilmiştir (RAM,ROMHD,CPU,BIOS,Display). Problemin içeriğine bakılırsa client tüm bu parçalara erişip bunlar üzerinden işlem yapmaktadır fakat bu olmaması gereken bir durumdur, bu durum client'ı karmaşık ve kırılgan yapar. Client sadece bilgisayar istemelidir ve bilgisayar nesnesinin üretildiği noktada alt sınıflarıyla iletişime geçmelidir. Yani Ön yüz bilgisayar olarak  tanımlanmalıdır.
Facade uygulandıktan sonra Client'ın sadece Computer'a ait Start metodunu çağırması yeterli olacaktır.


Client'ın sürecin detaylarını ve süreçteki nesneleri bilmesi, iş bölümü, teknolojik kısıtlar güvenlik vb açılardan da istenen bir durum değildir.

Sonuçlar

Karmaşık bir alt sistemi basit bir şekilde kullanmak için Façade güzel bir çözümdür.
• Façade, alt sistemlere bir giriş noktası sağlar.
• Façade, alt sistemlerin arayüzü (interface) olur.
• Façade, sürecin tüm detaylarını bilir ve arayüzünde bir seferde çok iş yapacak şekilde, coarse grained (Çok iş yapan) metotlar sağlar.
• Nasıl sınıflar birbirlerine arayüzleri üzerinden bağımlı olurlarsa ve bu arayüzleri olabildiğince minimal yapmak gerekliyse bir sistemin alt parçaları da birbirlerine minimal arayüzler üzerinden bağımlı olmalıdır.
• Bu şekilde alt sistemlerin birbirlerinin iç yapılarına bağımlı olmaması sağlanır.
• Ayrıca istemci ile alt sistemin parçaları arasındaki bağımlılık da ortadan kalkar.
• Gerektiğinde istemcinin alt sistemin parçalarına ulaşması söz konusu olabilir.
• Bu özelliklerinden dolayı Façade’ın birlikteliği (cohesion) düşük, bağımlılığı (coupling) yüksek olma eğilimindedir.
• Çünkü Façade gizlediği alt sistemin pek çok nesnesi ile haberleşir.
• Bu amaçla birden çok façade nesnesi kullanılabilir, hatta façadelar da katmanlı olabilir.
• Façade nesneleri de genelde durumsuz (stateless) nesnelerdir aksi taktirde durumlu (stateful) Façade nesnelerinin sayısı istemci sayısına paralel olarak artar ve bu da ölçeklenirlik (scalability) problemleri ortaya çıkarabilir.
• Façade, kurumsal uygulamalarda, sunucu tarafından hizmet alan, web, web servis, uzak vb. arayüzün, istemcinin sunucuya ulaştığı ilk nokta olması açısından da önemli bir role sahiptir.
• Dolayısıyla Façade, sunucu tarafının arayüzü olarak hizmet eder.
• Muhtemelen bu durumda birden fazla Façade nesnesi gereklidir.
• Façade, kurumsal uygulamalardaki katmanlar (tiers/layers) arasındaki ilişkiyi basitleştiren en temel kalıptır.
• Façade ile Adapter arasındaki fark, ilkinin karmaşık arayüzleri, basit olanla değiştirmesine karşın Adapter’in, uyumsuz arayüzü uyumlu hale getirmesidir.
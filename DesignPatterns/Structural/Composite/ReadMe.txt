Composite, nesneleri ağaç yapısında (tree structure) organize ederek hem bireysel nesneleri hem de bileşenlerden oluşan grupları aynı şekilde işlemeyi sağlar. Bu desen, özellikle hiyerarşik yapılar ile çalışırken kullanılır. 

Graphic Örneği

IGraphic sınıfını implement eden Circle,Ellipse,Rectangle,Triangle ve Canvas sınıflarıdır fakat bu sınıflardan Canvas diğer tüm sınıfların bileşimlerinin oluşturduğu bir yapıdır. Yani Canvas, içine Circle,Ellipse,Rectangle,Triangle şekillerinden herhangi/hepsi bulunduran yapıdır. 
Örnekte Canvas (IGraphic'i implement etmiştir)GraphicObject'dan kalıtım alıp ,ICompositeGraphic arayüzünü iplement etmektedir, bu implementasyon sayesinde composite bir yapı oluşturulmaktadır ve kalıtım aracılığıyla IGraphic üzerinden gelen bir metot çağırıldığında, composite içine eklenen tüm şekiller için o metot uygulanacaktır.

Process içerisinde polimorfizm kullanılarak ICompositeGraphic türünde bir Canvas nesnesi oluşturulup içine IGraphic implemente eden şekiller eklenmiştir. Ekleme işlemlerinden sonra kullanılan metotlar, eklenen tüm şekilleri etkileyecektir.

Sonuç olarak Composite üzerinde kullanılan bir metot, composite içinde bulundan tüm nesneleri de etkilemelidir.

File System

Bir FileSystem içinde File,Alias,Shortcut ve Directory nesneleri bulunmaktadır bu nesnelerden Directory diğerlerini de (kendi dahil) içinde bulundurabileceği Composite bir yapıdadır. IStorage'i implement eden tüm sınıfları yapısına ekleyip bir tree yapısı kurabilir ve IStorage'tan gelen bir meetot tetiklendiğinde tüm yapılarda bu işlemi yapacaktır.


• Parça-bütün ilişkisinin olduğu yerlerde Composite kalıbı kullanılabilir. Bu şekilde içiçe geçmiş pek çok parça-bütün ilişkisi yönetilebilir.
• İstemcinin, parça-bütün arasındaki farkı gözetmeden bu sistemi kullanması söz konusudur çünkü bileşik nesne de aynı zamanda parçadır.
• Bütün ile parçalar arasındaki ilişki tamamen, 'bütün nesne' tarafından yönetilir.

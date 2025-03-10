
* Nesne oluşturmak için gerekli olan parametreler olabildiğince Factory tarafından implemente edilen Create metodu üzerinden temin edilmelidir. Örneğin Date.Now() bilgisi parametre olarak alınmamalıdır, metodun ulaşabildiği parametreleri kendi temin etmelidir. Amacımız create metoduna olabildiğince az parametre geçerek objeyi oluşturmaktır.
* Her zaman create metodu gerekli parametrelere ulaşamayacaktır ama en az şekilde bu parametreleri almak gerekir. Create metoduna ne kadar az parametre geçilirse, Factory Method kalıbını kullanmaktan doğan fayda o denli artar. 
* Amacımız istemciyi, nesne oluşturmasından olabildiğince uzak tutmaktır.
* Eğer ki nesne oluşturulması için create metotları farklı parametreler alıyorsa bu sınıflarda aynı factory interfaceler kullanılamaz, bu nedenle sınıfa özel IFactory interfaceleri üretilmelidir. (Örneğin IPhDStudenFactory)

* Birbiriden farklı soyutlamalar(abstract) yerine somut(concrete) sınıf üzerinden nesne üretimini yönetmek başta mantıklı gelebilir fakat sakıncalı bir durumdur. Olasılıklara göre açıklamalar aşağıda yapılmıştır.
** Tek bir metot üzerinden nesne (Örneğin Students klasörü altındaki nesneler) üretimleri kontrol edilmeye çalışılırsa o metot çok fazla parametre alacaktır ayrıca içeride çok fazla if/else kullanımı olacaktır. OCP (Open-Closed Principles)'ye ve SRP'ye (Single Responsibilty Principles) uygun olmayacaktır. Factory Method'un amacı sadece 1 nesneyi soyutlamaktır.
** Her sınıf nesnesinin üretimi için bir metot üretildiği durumda (createPhdStudent,createUndergraduateStudent...) ise if/elselerden kurtulmuş oluruz OCP ve SRP iyileştirilmiş olur fakat bu concrete sınıf içeriği bir süre sonra utilty sınıfına dönecektir ve bu istenmeyen bir durumdur. Diğer önemli husus ise statik sınıflar extensible değildir bu nedenle başka bir sınıfa implement edilemezler, bizim burada yaptığımız Students nesnelerini farklı üniversiteler için kullanmak istersek create metotları üniversitelere göre farklılık gösterecektir. Statik sınıflar içinde bu durumun yönetilmesi büyük karmaşılığa neden olacaktır ayrıca farklı nesnelerin bir sınıf içinde üretilmesi de sınıf kohezyonunu (cohesion-birliktelik) düşerecektir.
** Aynı sınıfta ilgili nesne ailesini yaratan statik factory metotları bir araya getirilirse Abstract Factory'e yaklaşmış oluruz tek fark bir arayüzde tanımlanan abstract metotların alt sınıflarda override edilmesi yerine somut bir sınıfta static factory metotları söz konusudur.

Bloch'un Çözümü
	J.Bloch Effective Java kitabında kurucular yerine static üretici metotları tavsiye eder çünkü kurucuların ayırt edici isimleri yoktur ve bu yüzden de çağrılmaları zordur, hataya açıktır ama statik metotların anlamlı isimleri vardır.
	Nesne kurucuları private yapılır ve nesne kurucuları çağıran statik metotlar oluşturulur.
	Bu çözümde her sınıf kendi nesnesinin üreticisidir, bundan dolayı ayrı arayüz ve gerçekleştirmelerine ihtiyaç kalmaz, dolayısıyla factory methoda'a göre daha az karmaşıktır.

** Factory Method, nesne yaratma işinin kontrolünü sisteme bırakarak, istemcinin sadece nesneleri istemekle yetinebileceğini göstermektedir.
** Polimorfizm sayesinde istemci yaratılan nesnelerin gerçek tiplerini bilmeden onlarla haberleşebilmektedir.
** Bu yaklaşımın en temel problemi, her yeni sınıf için yeni bir factory alt sınıfına hatta ayrı arayüzler olması durumunda yeni arayüze ihtiyaç duymasıdır.
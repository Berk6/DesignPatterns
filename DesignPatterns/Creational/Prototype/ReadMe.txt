Uygulamalarda sıklıkla iş alanı sınıflarında nesneler oluşturulur, bazen bir sınıftan oluşturulan nesnelerin az sayıdaki birkaç durumdan birine sahip olması istenir. Fakat bu nesnelerin farklı durumlar için türetilmesi zor olabilir yani constructorı bir çok parametre alabilir. 
Bazen bu türden karmaşık nesneleri sıfırdan yaratmak yerine, hali hazırda elde var olan nesnelerden kopyalayarak (clone) elde etme yoluna gidilebilir. Durumu kopyalanarak çoğaltılan nesne protoip ya da örnek nesnedir.

Proptotip olarak oluşturulan nesne, aynı sınıftan diğer nesneler için bir başlangıç noktası olur. Dolayısıyla, yeni nesneleri oluşturmaya var olan prototipi kopyalayarak başlarız.
Kopyalama ile elde edilen nesnenin durumu, prototip ile aynıdır. Dolayısıyle yeni nesnenin kendine has duruma sahip olması gereklidir, bu yüzden prototip ile yeni nesnenin olması gereken durumu arasındaki farklılık, yeni nesne üzerinde set metotları çağrılarak giderilir.

Clonelama yöntemi ile devamlı constructor çağrısı yapmak zorunda kalmıyoruz fakat set metotlarını kullanarak yeni değerler atıyoruz. İstemciyi prototipleri bilmekten ve set metot çağrıları yapmaktan alıkoymak gereklidir.

//Account1
Prototype kalıbı nesnelerin nasıl üretileceğini çözer, nerede üretileceğiyle ilgilenmez dolayısıyla nesne yaratmayı soyutlamaz. Dolayısıyla Prototype kalıbı ile yeni nesne oluşturma farklı yerlerde gerçekleştirilebilir: Factory metotları, Bloch'un önerdiği gibi static factory metotlarında.

//Account2
İstenirse nesnelerin belirli durumları için farklı farklı prototipler üretilir. Çok sık kullanılan nesne durumları için prototip üretimi nesne üzerinde yapılcak durum değişikliklerini azaltacaktır.

//Account3
Prototip sayısı çoğaldıkça kullanım zorlaşacaktır bu nedenle böyle bir durumda prototip nesneler ayrı bir yerde örneğin static bir iç sınıfta tutulabilir. Prototip sayısının artması durumunda bu yaklaşım  abstract factory sınıfını rahatlatır.

//Account4 (Bloch çözümü)
Prototype nesneler aynı sınıf üzerinde static olarak tutulabilir. Bu işlemde contructor private hale getirilerek, ilgili nesne clonelarına nesne içindeki statik metotlar ile erişilir.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Creational.Singleton
{
    internal class Singleton
    {//Statik fieldlar nesnelerden daha önce initialize edilirler, dolayısıyla ilk istendiği noktada değil Class oluşum noktasında bu nesne oluşacaktır. Bu nedenle başlangıçta fazladan yüke neden olacaktır. (eager loading)
        private static Singleton _singleton = new();
        private Singleton()
        {
            _count++;
            _name = "Singleton" + _count;
        }

        private static int _count;
        private readonly string _name;
        public static Singleton Instance
        {
            get { return _singleton; }
        }
        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
    internal class LazySingleton
    {//Burada ise objenin nesnesi sınıf çağırıldığında initialize edildi/üretildi.
        //Fakat lazy-loaded singletonlarda ise multi-thread ortamlarda aynı anda birden fazla kanalın aynı anda null kontrolü yapması birden çok singleton nesnesi oluşmasına neden olmaktadır.
        private static LazySingleton _singleton;
        private LazySingleton()
        {
            _count++;
            _name = "Singleton" + _count;
        }

        private static int _count;
        private readonly string _name;
        public static LazySingleton Instance
        {
            get
            {
                _singleton ??= new LazySingleton();
                return _singleton;
            }
        }
        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
    internal class ThreadSafeLazySingleton
    {//Multi-Thread ortamlarda Lazy Loading'i Thread Safe hale döndürmek için lock yapısı kullanılır.
        private static ThreadSafeLazySingleton _singleton;
        private static readonly object _lock = new object();
        private ThreadSafeLazySingleton()
        {
            _count++;
            _name = "ThreadSafeLazySingleton" + _count;
        }

        private static int _count;
        private readonly string _name;
        public static ThreadSafeLazySingleton Instance
        {
            get
            {
                lock (_lock)
                    _singleton ??= new ThreadSafeLazySingleton();
                return _singleton;
            }
        }
        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
    internal class ThreadSafeLazySingleton2
    {//Multi-Thread ortamlarda Lazy Loading'i Thread Safe hale döndürmek Lazy yapısı kullanılabilir.
        private static readonly Lazy<ThreadSafeLazySingleton2> _instance = new(() => new ThreadSafeLazySingleton2());
        private ThreadSafeLazySingleton2()
        {
            _count++;
            _name = "ThreadSafeLazySingleton2" + _count;
        }

        private static int _count;
        private readonly string _name;
        public static ThreadSafeLazySingleton2 Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
    internal class DoubleCheckLockingSingleton
    {
        // Multi-thread işlemlerde _lock koymamıza rağmen birden çok nesne üretilebilir, örneğin nesne üretildiği halde bunu ilgili dataya yazmamış olabilir bu nedenle _singleton ??= new DoubleCheckLockingSingleton(); alanı yeni bir nesne üretebilir. Bu durumun önüne geçmek için volatile keyword'ü kullanılır.
        //Volatile keywordü, işaretlediği değişkenin data register optimizasyonuna uğramadan direkt olarak bellek üzerinden temasını gerçekleştirir. Yapılan güncellemeler anlık belleğe yansıyacak ve son güncellemeler ne ise onlarla çalışılacaktır. Detaylı bilgi için https://www.gencayyildiz.com/blog/cta-volatile-anahtar-sozcugu/ bakılabilir.
        private static volatile DoubleCheckLockingSingleton? _singleton;
        private static readonly object _lock = new();
        private DoubleCheckLockingSingleton()
        {
            _count++;
            _name = "DoubleCheckLockingSingleton" + _count;
        }

        private static int _count;
        private readonly string _name;
        internal static DoubleCheckLockingSingleton Instance
        {
            get
            {//ThreadSafeLazySingleton class'ı gözlemlenecek olursa lock kontrolü singleton nesnesi üretildikten sonra da yapılmaya devam etmektedir fakat bu durum performans sorununa neden olmaktadır. Singleton nesnesi üretildikten sonra lock kotrolü gereksizdir çünkü bu kontrol multi-thread yapıda birden çok nesne üretilmesini engellemek için kullanılmıştır. 2 kez null kontrolü yapılarak gereksiz lock kontrolünün önüne geçilmiştir.
                if (_singleton == null)
                    lock (_lock)
                        _singleton ??= new DoubleCheckLockingSingleton();
                return _singleton;
            }
        }
        internal void PrintName()
        {
            Console.WriteLine(_name);
        }
    }

    internal class BillPughSingleton
    {        //Bill Pugh yönteminde inner Class içerisinde nesne üretimi yapılır bu durum hem thread-safe hem de lazy loadingi içinde barındırır. 
        private static int _count;
        private readonly string _name;
        private BillPughSingleton()
        {
            _count++;
            _name = "BillPughSingleton" + _count;
        }

        public static BillPughSingleton GetInstance() => SingletonHelper.Instance;
        private static class SingletonHelper
        {
            internal static readonly BillPughSingleton Instance = new BillPughSingleton();
        }
        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
    //Singleton yapı oluşturulurken private constructor kullanımı durumu, Reflection ve Serialize işlemleri ile aşılabilir ve birden çok nesne üretilebilir. 
    //Bu sıkıntılardan kaçınmak için Javada enumaration ile singleton yönetiliyor fakat c#'ta bunu yapamadım bu nedenle aşağıdaki yönteme youtube üzerinden denk geldim https://www.youtube.com/watch?v=M8P2dUC59kA&t=5s&ab_channel=NaveenAutomationLabs. Eğer ki Reflection ile nesne üretimi yapılmak istenirse _isInstanceCreated field'ı kontrol ediliyor eğer ki false ise nesne üreitliyor ve _singleton field'ına set ediliyor eğer ki true ise exception fırlatarak nesne üretim işlemi engelleniyor.

    internal class SingletonException
    {
        private volatile static SingletonException _singleton;
        private static readonly object _lock = new();
        private static int _count;
        private static bool _isInstanceCreated = false;
        private SingletonException()
        {
            if (_isInstanceCreated)
                throw new Exception("Object allready exist");
            else
            {
                _isInstanceCreated = true;
                _singleton = this;
            }
            _count++;
        }
        public static SingletonException GetInstance()
        {
            if (_singleton == null)
                lock (_lock)
                    _singleton ??= new SingletonException();
            return _singleton;
        }
        public void PrintName()
        {
            Console.WriteLine(_count);
        }
    }

    public class EnumSingletonWrapper
    {//JAVADA bu şekilde nesne üretimi kontrol edilebiliyor fakt c#'ta tam anlamıyla işlevsellik gösteremiyor. Araştırdım fakat bununla ilgili bir bilgiye c# tarafında ulaşamadım.
        public enum EnumSingleton
        {
            SINGLETON
        }

        private EnumSingletonWrapper() { }
        public static EnumSingleton Instance
        {
            get { return EnumSingleton.SINGLETON; }
        }
        public void PrintName() { }
    }
    //Singleton nesne üzerinde güncelleme işlemi, ya da propertylerde set işlemi yapılırken karışıklığın olmaması için lock mekanızması kullanılmalıdır. Yani bir objeyi birden çok yer aynı anda güncellememelidir.
}



namespace DesignePatterns.CreationalPatterns.Singelton
{
    public sealed class Logger
    {

        #region No_Thread_Safe_Singleton

        /// <summary>
        /// The following code is not thread-safe.
        /// Two different threads could both have evaluated the test (if instance == null) and found it to be true,
        /// then both create instances, which violates the singleton pattern.  
        /// </summary>

        //private Logger() { }
        //private static Logger instance = null;
        //public static Logger Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Logger();
        //        return instance;
        //    }

        //}
        #endregion

        #region Thread_Safe_Singleton

        /// <summary>
        /// The following code is thread-safe.
        /// In the code, the thread is locked on a shared object and checks whether an instance has been created or not.
        /// It takes care of the memory barrier issue and ensures that only one thread will create an instance.
        /// For example: Since only one thread can be in that part of the code at a time,
        /// by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate as false.
        /// The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
        /// </summary>


        //private static readonly object Lock = new object();
        //private static Logger instance2 = null;
        //public static Logger Instance2
        //{
        //    get
        //    {
        //        lock (Lock)
        //            if (instance2 == null)
        //                instance2 = new Logger();
        //        return instance2;
        //    }
        //}
        #endregion

        #region Thread_Safety_Singleton_using_Double-Check_Locking

        //In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.

        //private static readonly object Lock2 = new object();
        //private static Logger instance3 = null;
        //public static Logger Instance3
        //{
        //    get
        //    {
        //        if (instance3 == null)
        //            lock (Lock2)
        //                if (instance3 == null)
        //                    instance3 = new Logger();
        //        return instance3;
        //    }
        //}
        #endregion

        #region Thread_Safe_Singleton_without_using_locks_and_no_lazy_instantiation

        /// <summery>
        /// The preceding implementation looks like a very simple code.
        /// This type of implementation has a static constructor, so it executes only once per Application Domain.
        /// It is not as lazy as the other implementation.
        /// </summery>

        //private static readonly Logger instance4 = new Logger();
        //static Logger() { }
        //private Logger() { }
        //public static Logger Instance4
        //{
        //    get
        //    {
        //        return instance4;
        //    }
        //}
        #endregion

        #region Using_.NET_4's_Lazy<T>_type
        
        /// <summary>
        /// If you are using .NET 4 or higher then you can use the System.Lazy<T> type to make the laziness really simple.
        /// You can pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.
        /// Allows you to check whether or not the instance has been created with the IsValueCreated property.    
        /// </summary>

        //private Logger() { }
        //private static readonly Lazy<Logger> Lazy = new Lazy<Logger>(()=>new Logger());
        //public static Logger Instance5
        //{
        //    get
        //    {
        //        return Lazy.Value;
        //    }
        //}
        #endregion


        public void Log(string message)
            => Console.WriteLine($"[Log] {message}");
    }
}
